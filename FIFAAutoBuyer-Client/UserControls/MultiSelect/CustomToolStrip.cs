﻿using System; 
using System.ComponentModel; 
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FIFAAutoBuyer_Client.UserControls.MultiSelect
{
    public partial class CustomToolStrip : ToolStripDropDown
    { 
        private Control content; 
        public Control Content
        {
            get { return content; }
        }

        private bool fade; 

        public bool UseFadeEffect
        {
            get { return fade; }
            set
            {
                if (fade == value) return;
                fade = value;
            }
        }

        private bool focusOnOpen = true; 

        public bool FocusOnOpen
        {
            get { return focusOnOpen; }
            set { focusOnOpen = value; }
        }

        private bool acceptAlt = true; 

        public bool AcceptAlt
        {
            get { return acceptAlt; }
            set { acceptAlt = value; }
        }

        private CustomToolStrip ownerToolStrip;
        private CustomToolStrip childToolStrip;

        private bool _resizable;
        private bool resizable; 

        public bool Resizable
        {
            get { return resizable && _resizable; }
            set { resizable = value; }
        }

        private ToolStripControlHost host;

        private Size minSize;

        public new Size MinimumSize
        {
            get { return minSize; }
            set { minSize = value; }
        }

        private Size maxSize;

        public new Size MaximumSize
        {
            get { return maxSize; }
            set { maxSize = value; }
        }

        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= NativeMethods.WS_EX_NOACTIVATE;
                return cp;
            }
        } 

        public CustomToolStrip(Control content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            this.content = content;
            this.fade = SystemInformation.IsMenuAnimationEnabled && SystemInformation.IsMenuFadeEnabled;
            this._resizable = true;
            InitializeComponent();
            AutoSize = false;
            DoubleBuffered = true;
            ResizeRedraw = true;
            host = new ToolStripControlHost(content);
            Padding = Margin = host.Padding = host.Margin = Padding.Empty;
            MinimumSize = content.MinimumSize;
            content.MinimumSize = content.Size;
            MaximumSize = content.MaximumSize;
            content.MaximumSize = content.Size;
            Size = content.Size;
            content.Location = Point.Empty;
            Items.Add(host);
            content.Disposed += delegate (object sender, EventArgs e)
            {
                content = null;
                Dispose(true);
            };
            content.RegionChanged += delegate (object sender, EventArgs e)
            {
                UpdateRegion();
            };
            content.Paint += delegate (object sender, PaintEventArgs e)
            {
                PaintSizeGrip(e);
            };
            UpdateRegion();
        } 

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (acceptAlt && ((keyData & Keys.Alt) == Keys.Alt)) return false;
            return base.ProcessDialogKey(keyData);
        }

        protected void UpdateRegion()
        {
            if (this.Region != null)
            {
                this.Region.Dispose();
                this.Region = null;
            }
            if (content.Region != null)
            {
                this.Region = content.Region.Clone();
            }
        }

        public void Show(Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }
            SetOwnerItem(control);
            Show(control, control.ClientRectangle);
        }

        public void Show(Control control, Rectangle area)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }
            SetOwnerItem(control);
            resizableTop = resizableRight = false;
            Point location = control.PointToScreen(new Point(area.Left, area.Top + area.Height));
            Rectangle screen = Screen.FromControl(control).WorkingArea;
            if (location.X + Size.Width > (screen.Left + screen.Width))
            {
                resizableRight = true;
                location.X = (screen.Left + screen.Width) - Size.Width;
            }
            if (location.Y + Size.Height > (screen.Top + screen.Height))
            {
                resizableTop = true;
                location.Y -= Size.Height + area.Height;
            }
            location = control.PointToClient(location);
            Show(control, location, ToolStripDropDownDirection.BelowRight);
        }

        private const int frames = 1;
        private const int totalduration = 0;
        private const int frameduration = totalduration / frames;

        protected override void SetVisibleCore(bool visible)
        {
            double opacity = Opacity;
            if (visible && fade && focusOnOpen) Opacity = 0;
            base.SetVisibleCore(visible);
            if (!visible || !fade || !focusOnOpen) return;
            for (int i = 1; i <= frames; i++)
            {
                if (i > 1)
                {
                    System.Threading.Thread.Sleep(frameduration);
                }
                Opacity = opacity * (double)i / (double)frames;
            }
            Opacity = opacity;
        }

        private bool resizableTop;
        private bool resizableRight;

        private void SetOwnerItem(Control control)
        {
            if (control == null)
            {
                return;
            }
            if (control is CustomToolStrip)
            {
                CustomToolStrip toolStrip = control as CustomToolStrip;
                ownerToolStrip = toolStrip;
                ownerToolStrip.childToolStrip = this;
                OwnerItem = toolStrip.Items[0];
                return;
            }
            if (control.Parent != null)
            {
                SetOwnerItem(control.Parent);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            content.MinimumSize = Size;
            content.MaximumSize = Size;
            content.Size = Size;
            content.Location = Point.Empty;
            base.OnSizeChanged(e);
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            if (content.IsDisposed || content.Disposing)
            {
                e.Cancel = true;
                return;
            }
            UpdateRegion();
            base.OnOpening(e);
        }

        protected override void OnOpened(EventArgs e)
        {
            if (ownerToolStrip != null)
            {
                ownerToolStrip._resizable = false;
            }
            if (focusOnOpen)
            {
                content.Focus();
            }
            base.OnOpened(e);
        }

        protected override void OnClosed(ToolStripDropDownClosedEventArgs e)
        {
            if (ownerToolStrip != null)
            {
                ownerToolStrip._resizable = true;
            }
            base.OnClosed(e);
        }

        public DateTime LastClosedTimeStamp = DateTime.Now;

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (Visible == false)
                LastClosedTimeStamp = DateTime.Now;
            base.OnVisibleChanged(e);
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (InternalProcessResizing(ref m, false))
            {
                return;
            }
            base.WndProc(ref m);
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public bool ProcessResizing(ref Message m)
        {
            return InternalProcessResizing(ref m, true);
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private bool InternalProcessResizing(ref Message m, bool contentControl)
        {
            if (m.Msg == NativeMethods.WM_NCACTIVATE && m.WParam != IntPtr.Zero && childToolStrip != null && childToolStrip.Visible)
            {
                childToolStrip.Hide();
            }
            if (!Resizable)
            {
                return false;
            }
            if (m.Msg == NativeMethods.WM_NCHITTEST)
            {
                return OnNcHitTest(ref m, contentControl);
            }
            else if (m.Msg == NativeMethods.WM_GETMINMAXINFO)
            {
                return OnGetMinMaxInfo(ref m);
            }
            return false;
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private bool OnGetMinMaxInfo(ref Message m)
        {
            NativeMethods.MINMAXINFO minmax = (NativeMethods.MINMAXINFO)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.MINMAXINFO));
            minmax.maxTrackSize = this.MaximumSize;
            minmax.minTrackSize = this.MinimumSize;
            Marshal.StructureToPtr(minmax, m.LParam, false);
            return true;
        }

        private bool OnNcHitTest(ref Message m, bool contentControl)
        {
            int x = NativeMethods.LOWORD(m.LParam);
            int y = NativeMethods.HIWORD(m.LParam);
            Point clientLocation = PointToClient(new Point(x, y));

            GripBounds gripBouns = new GripBounds(contentControl ? content.ClientRectangle : ClientRectangle);
            IntPtr transparent = new IntPtr(NativeMethods.HTTRANSPARENT);

            if (resizableTop)
            {
                if (resizableRight && gripBouns.TopLeft.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTTOPLEFT;
                    return true;
                }
                if (!resizableRight && gripBouns.TopRight.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTTOPRIGHT;
                    return true;
                }
                if (gripBouns.Top.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTTOP;
                    return true;
                }
            }
            else
            {
                if (resizableRight && gripBouns.BottomLeft.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTBOTTOMLEFT;
                    return true;
                }
                if (!resizableRight && gripBouns.BottomRight.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTBOTTOMRIGHT;
                    return true;
                }
                if (gripBouns.Bottom.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTBOTTOM;
                    return true;
                }
            }
            if (resizableRight && gripBouns.Left.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTLEFT;
                return true;
            }
            if (!resizableRight && gripBouns.Right.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : (IntPtr)NativeMethods.HTRIGHT;
                return true;
            }
            return false;
        }

        private VisualStyleRenderer sizeGripRenderer;

        public void PaintSizeGrip(PaintEventArgs e)
        {
            if (e == null || e.Graphics == null || !resizable)
            {
                return;
            }
            Size clientSize = content.ClientSize;
            if (Application.RenderWithVisualStyles)
            {
                if (this.sizeGripRenderer == null)
                {
                    this.sizeGripRenderer = new VisualStyleRenderer(VisualStyleElement.Status.Gripper.Normal);
                }
                this.sizeGripRenderer.DrawBackground(e.Graphics, new Rectangle(clientSize.Width - 0x10, clientSize.Height - 0x10, 0x10, 0x10));
            }
            else
            {
                ControlPaint.DrawSizeGrip(e.Graphics, content.BackColor, clientSize.Width - 0x10, clientSize.Height - 0x10, 0x10, 0x10);
            }
        }         
    }
}
