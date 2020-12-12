using Guna.UI2.WinForms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.UserControls.MultiSelect
{ 
    [ToolboxBitmap(typeof(MetroComboBox)), ToolboxItem(true), ToolboxItemFilter("System.Windows.Forms"), Description("Displays an editable text box with a drop-down list of permitted values.")]
    public partial class ComboBoxPopUp : MetroComboBox
    { 
        public ComboBoxPopUp()
        {
            InitializeComponent();
            base.DropDownHeight = base.DropDownWidth = 1;
            base.IntegralHeight = false;
        }
         
        protected CustomToolStrip dropDown;

        private Control dropDownControl; 

        public Control DropDownControl
        {
            get
            {
                return dropDownControl;
            }
            set
            {
                if (dropDownControl == value)
                    return;
                dropDownControl = value;
                dropDown = new CustomToolStrip(value);
            }
        } 

        public void ShowDropDown()
        {
            if (dropDown != null)
            {
                dropDown.Show(this);
            }
        }
         
        public void HideDropDown()
        {
            if (dropDown != null)
            {
                dropDown.Hide();
            }
        } 

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (NativeMethods.WM_REFLECT + NativeMethods.WM_COMMAND))
            {
                if (NativeMethods.HIWORD(m.WParam) == NativeMethods.CBN_DROPDOWN)
                { 
                    TimeSpan TimeSpan = DateTime.Now.Subtract(dropDown.LastClosedTimeStamp);
                    if (TimeSpan.TotalMilliseconds > 500)
                        ShowDropDown();
                    return;
                }
            }
            base.WndProc(ref m);
        } 

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new int DropDownWidth
        {
            get { return base.DropDownWidth; }
            set { base.DropDownWidth = value; }
        } 

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new int DropDownHeight
        {
            get { return base.DropDownHeight; }
            set
            {
                dropDown.Height = value;
                base.DropDownHeight = value;
            }
        } 

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new bool IntegralHeight
        {
            get { return base.IntegralHeight; }
            set { base.IntegralHeight = value; }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new ObjectCollection Items
        {
            get { return base.Items; }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new int ItemHeight
        {
            get { return base.ItemHeight; }
            set { base.ItemHeight = value; }
        } 
    }
}
