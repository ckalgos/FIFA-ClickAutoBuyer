using FIFAAutoBuyer_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.UserControls.MultiSelect
{
    public partial class MultiSelectComboBox : ComboBoxPopUp
    {
        public MultiSelectComboBox() : base()
        { 
            InitializeComponent();
            _CheckBoxProperties = new CheckBoxProperties();
            _CheckBoxProperties.PropertyChanged += new EventHandler(_CheckBoxProperties_PropertyChanged);

            CheckBoxComboBoxListControlContainer ContainerControl = new CheckBoxComboBoxListControlContainer();
            _CheckBoxComboBoxListControl = new CheckBoxComboBoxListControl(this);
            _CheckBoxComboBoxListControl.Items.CheckBoxCheckedChanged += new EventHandler(Items_CheckBoxCheckedChanged);
            ContainerControl.Controls.Add(_CheckBoxComboBoxListControl);

            ContainerControl.Padding = new Padding(4, 0, 0, 14);

            _CheckBoxComboBoxListControl.Dock = DockStyle.Fill;

            DropDownControl = ContainerControl;

            dropDown.Resizable = true;
        }

        internal CheckBoxComboBoxListControl _CheckBoxComboBoxListControl;

        private string _DisplayMemberSingleItem = null;
        internal bool _MustAddHiddenItem = false;

        internal string GetCSVText(bool skipFirstItem)
        {
            string ListText = String.Empty;
            int StartIndex =
                DropDownStyle == ComboBoxStyle.DropDownList
                && DataSource == null
                && skipFirstItem
                    ? 1
                    : 0;
            for (int Index = StartIndex; Index <= _CheckBoxComboBoxListControl.Items.Count - 1; Index++)
            {
                CheckBoxComboBoxItem Item = _CheckBoxComboBoxListControl.Items[Index];
                if (Item.Checked)
                    ListText += string.IsNullOrEmpty(ListText) ? Item.Text : String.Format(", {0}", Item.Text);
            }
            return ListText;
        }

        [Browsable(false)]
        public CheckBoxComboBoxItemList CheckBoxItems
        {
            get
            {
                if (_CheckBoxComboBoxListControl.Items.Count != Items.Count)
                    _CheckBoxComboBoxListControl.SynchroniseControlsWithComboBoxItems();
                return _CheckBoxComboBoxListControl.Items;
            }
        }

        public new object DataSource
        {
            get { return base.DataSource; }
            set
            {
                base.DataSource = value;
                if (!string.IsNullOrEmpty(ValueMember))

                    _CheckBoxComboBoxListControl.SynchroniseControlsWithComboBoxItems();
            }
        }

        public new string ValueMember
        {
            get { return base.ValueMember; }
            set
            {
                base.ValueMember = value;
                if (!string.IsNullOrEmpty(ValueMember))

                    _CheckBoxComboBoxListControl.SynchroniseControlsWithComboBoxItems();
            }
        }

        public string DisplayMemberSingleItem
        {
            get { if (string.IsNullOrEmpty(_DisplayMemberSingleItem)) return DisplayMember; else return _DisplayMemberSingleItem; }
            set { _DisplayMemberSingleItem = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new ObjectCollection Items
        {
            get { return base.Items; }
        }

        public event EventHandler CheckBoxCheckedChanged;

        private void Items_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            OnCheckBoxCheckedChanged(sender, e);
        }

        protected void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            string ListText = GetCSVText(true);

            if (DropDownStyle != ComboBoxStyle.DropDownList)
                Text = ListText;

            else if (DataSource == null)
            {
                Items[0] = ListText;

                CheckBoxItems[0].ComboBoxItem = ListText;
            }

            EventHandler handler = CheckBoxCheckedChanged;
            if (handler != null)
                handler(sender, e);
        }

        protected override void OnDropDownStyleChanged(EventArgs e)
        {
            base.OnDropDownStyleChanged(e);

            if (DropDownStyle == ComboBoxStyle.DropDownList
                && DataSource == null
                && !DesignMode)
                _MustAddHiddenItem = true;
        }

        protected override void OnResize(EventArgs e)
        {
            Size Size = new Size(Width, DropDownControl.Height);
            dropDown.Size = Size;
            base.OnResize(e);
        }

        public void Clear()
        {
            this.Items.Clear();
            if (DropDownStyle == ComboBoxStyle.DropDownList && DataSource == null)
                _MustAddHiddenItem = true;
        }

        public void ClearSelection()
        {
            foreach (CheckBoxComboBoxItem Item in CheckBoxItems)
                if (Item.Checked)
                    Item.Checked = false;
        }

        private CheckBoxProperties _CheckBoxProperties;

        [Description("The properties that will be assigned to the checkboxes as default values.")]
        [Browsable(true)]
        public CheckBoxProperties CheckBoxProperties
        {
            get { return _CheckBoxProperties; }
            set { _CheckBoxProperties = value; _CheckBoxProperties_PropertyChanged(this, EventArgs.Empty); }
        }

        private void _CheckBoxProperties_PropertyChanged(object sender, EventArgs e)
        {
            foreach (CheckBoxComboBoxItem Item in CheckBoxItems)
                Item.ApplyProperties(CheckBoxProperties);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 331
                && DropDownStyle == ComboBoxStyle.DropDownList
                && DataSource == null)
            {
                _MustAddHiddenItem = true;
            }

            base.WndProc(ref m);
        }
    }

    [ToolboxItem(false)]
    public class CheckBoxComboBoxListControlContainer : UserControl
    {
        public CheckBoxComboBoxListControlContainer()
            : base()
        {
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.FixedSingle;
            AutoScaleMode = AutoScaleMode.Inherit;
            ResizeRedraw = true;

            MinimumSize = new Size(1, 1);
            MaximumSize = new Size(500, 500);
        }

        protected override void WndProc(ref Message m)
        {
            if ((Parent as CustomToolStrip).ProcessResizing(ref m))
            {
                return;
            }
            base.WndProc(ref m);
        }
    }

    [ToolboxItem(false)]
    public class CheckBoxComboBoxListControl : ScrollableControl
    {
        public CheckBoxComboBoxListControl(MultiSelectComboBox owner)
            : base()
        {
            DoubleBuffered = true;
            _CheckBoxComboBox = owner;
            _Items = new CheckBoxComboBoxItemList(_CheckBoxComboBox);
            BackColor = SystemColors.Window;

            AutoScroll = true;
            ResizeRedraw = true;

            MinimumSize = new Size(1, 1);
            MaximumSize = new Size(500, 500);
        }

        private MultiSelectComboBox _CheckBoxComboBox;

        private CheckBoxComboBoxItemList _Items;

        public CheckBoxComboBoxItemList Items { get { return _Items; } }

        protected override void WndProc(ref Message m)
        {
            if ((Parent.Parent as CustomToolStrip).ProcessResizing(ref m))
            {
                return;
            }
            base.WndProc(ref m);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            SynchroniseControlsWithComboBoxItems();
            base.OnVisibleChanged(e);
        }

        public void SynchroniseControlsWithComboBoxItems()
        {
            SuspendLayout();
            if (_CheckBoxComboBox._MustAddHiddenItem)
            {
                _CheckBoxComboBox.Items.Insert(
                    0, _CheckBoxComboBox.GetCSVText(false));
                _CheckBoxComboBox.SelectedIndex = 0;
                _CheckBoxComboBox._MustAddHiddenItem = false;
            }
            Controls.Clear();

            for (int Index = _Items.Count - 1; Index >= 0; Index--)
            {
                CheckBoxComboBoxItem Item = _Items[Index];
                if (!_CheckBoxComboBox.Items.Contains(Item.ComboBoxItem))
                {
                    _Items.Remove(Item);
                    Item.Dispose();
                }
            }

            bool HasHiddenItem =
                _CheckBoxComboBox.DropDownStyle == ComboBoxStyle.DropDownList
                && _CheckBoxComboBox.DataSource == null
                && !DesignMode;

            CheckBoxComboBoxItemList NewList = new CheckBoxComboBoxItemList(_CheckBoxComboBox);
            for (int Index0 = 0; Index0 <= _CheckBoxComboBox.Items.Count - 1; Index0++)
            {
                object Object = _CheckBoxComboBox.Items[Index0];
                CheckBoxComboBoxItem Item = null;

                if (Index0 == 0 && HasHiddenItem && _Items.Count > 0)
                    Item = _Items[0];
                else
                {
                    int StartIndex = HasHiddenItem ? 1 : 0;
                    for (int Index1 = StartIndex; Index1 <= _Items.Count - 1; Index1++)
                    {
                        if (_Items[Index1].ComboBoxItem == Object)
                        {
                            Item = _Items[Index1];
                            break;
                        }
                    }
                }
                if (Item == null)
                {
                    Item = new CheckBoxComboBoxItem(_CheckBoxComboBox, Object);
                    Item.ApplyProperties(_CheckBoxComboBox.CheckBoxProperties);
                }
                NewList.Add(Item);
                Item.Dock = DockStyle.Top;
            }
            _Items.Clear();
            _Items.AddRange(NewList);

            if (NewList.Count > 0)
            {
                NewList.Reverse();

                Controls.AddRange(NewList.ToArray());
            }

            if (_CheckBoxComboBox.DropDownStyle == ComboBoxStyle.DropDownList
                && _CheckBoxComboBox.DataSource == null
                && !DesignMode)
                _CheckBoxComboBox.CheckBoxItems[0].Visible = false;

            ResumeLayout();
        }
    }

    [ToolboxItem(false)]
    public class CheckBoxComboBoxItem : CheckBox
    {
        public CheckBoxComboBoxItem(MultiSelectComboBox owner, object comboBoxItem)
            : base()
        {
            DoubleBuffered = true;
            _CheckBoxComboBox = owner;
            _ComboBoxItem = comboBoxItem;
            if (_CheckBoxComboBox.DataSource != null)
                AddBindings();
            else
            {
                if (comboBoxItem is DropDownCheckOption checkOption && checkOption.DisplayValue != null)
                {
                    Tag = checkOption.Id.ToString();
                    Text = checkOption.DisplayValue.ToString();
                }
                else
                {
                    Text = comboBoxItem.ToString();
                }
            }
        }

        private MultiSelectComboBox _CheckBoxComboBox;

        private object _ComboBoxItem;

        public object ComboBoxItem
        {
            get { return _ComboBoxItem; }
            internal set { _ComboBoxItem = value; }
        }

        public void AddBindings()
        {
            DataBindings.Add(
                "Text",
                _ComboBoxItem,
                _CheckBoxComboBox.DisplayMemberSingleItem
                );

            DataBindings.Add(
                "Checked",
                _ComboBoxItem,
                _CheckBoxComboBox.ValueMember,
                false,
                DataSourceUpdateMode.OnPropertyChanged,
                false, null, null);

            if (_ComboBoxItem is INotifyPropertyChanged)
                ((INotifyPropertyChanged)_ComboBoxItem).PropertyChanged +=
                    new PropertyChangedEventHandler(
                        CheckBoxComboBoxItem_PropertyChanged);
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            if (_CheckBoxComboBox.DataSource != null)
            {
                PropertyInfo PI = ComboBoxItem.GetType().GetProperty(_CheckBoxComboBox.ValueMember);
                PI.SetValue(ComboBoxItem, Checked, null);
            }
            base.OnCheckedChanged(e);

            if (_CheckBoxComboBox.DataSource != null)
            {
                string OldDisplayMember = _CheckBoxComboBox.DisplayMember;
                _CheckBoxComboBox.DisplayMember = null;
                _CheckBoxComboBox.DisplayMember = OldDisplayMember;
            }
        }

        internal void ApplyProperties(CheckBoxProperties properties)
        {
            this.Appearance = properties.Appearance;
            this.AutoCheck = properties.AutoCheck;
            this.AutoEllipsis = properties.AutoEllipsis;
            this.AutoSize = properties.AutoSize;
            this.CheckAlign = properties.CheckAlign;
            this.FlatAppearance.BorderColor = properties.FlatAppearanceBorderColor;
            this.FlatAppearance.BorderSize = properties.FlatAppearanceBorderSize;
            this.FlatAppearance.CheckedBackColor = properties.FlatAppearanceCheckedBackColor;
            this.FlatAppearance.MouseDownBackColor = properties.FlatAppearanceMouseDownBackColor;
            this.FlatAppearance.MouseOverBackColor = properties.FlatAppearanceMouseOverBackColor;
            this.FlatStyle = properties.FlatStyle;
            this.ForeColor = properties.ForeColor;
            this.RightToLeft = properties.RightToLeft;
            this.TextAlign = properties.TextAlign;
            this.ThreeState = properties.ThreeState;
        }

        private void CheckBoxComboBoxItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == _CheckBoxComboBox.ValueMember)
                Checked =
                    (bool)_ComboBoxItem
                        .GetType()
                        .GetProperty(_CheckBoxComboBox.ValueMember)
                        .GetValue(_ComboBoxItem, null);
        }
    }

    [ToolboxItem(false)]
    public class CheckBoxComboBoxItemList : List<CheckBoxComboBoxItem>
    {
        public CheckBoxComboBoxItemList(MultiSelectComboBox checkBoxComboBox)
        {
            _CheckBoxComboBox = checkBoxComboBox;
        }

        private MultiSelectComboBox _CheckBoxComboBox;

        public event EventHandler CheckBoxCheckedChanged;

        protected void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EventHandler handler = CheckBoxCheckedChanged;
            if (handler != null)
                handler(sender, e);
        }
        private void item_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckBoxCheckedChanged(sender, e);
        }
         
        public new void Add(CheckBoxComboBoxItem item)
        {
            item.CheckedChanged += new EventHandler(item_CheckedChanged);
            base.Add(item);
        }

        public new void AddRange(IEnumerable<CheckBoxComboBoxItem> collection)
        {
            foreach (CheckBoxComboBoxItem Item in collection)
                Item.CheckedChanged += new EventHandler(item_CheckedChanged);
            base.AddRange(collection);
        }

        public new void Clear()
        {
            foreach (CheckBoxComboBoxItem Item in this)
                Item.CheckedChanged -= item_CheckedChanged;
            base.Clear();
        }
         
        public new bool Remove(CheckBoxComboBoxItem item)
        {
            item.CheckedChanged -= item_CheckedChanged;
            return base.Remove(item);
        }

        public CheckBoxComboBoxItem this[string displayName]
        {
            get
            {
                int StartIndex =

                    _CheckBoxComboBox.DropDownStyle == ComboBoxStyle.DropDownList
                    && _CheckBoxComboBox.DataSource == null ? 1 : 0;
                for (int Index = StartIndex; Index <= Count - 1; Index++)
                {
                    CheckBoxComboBoxItem Item = this[Index];

                    string Text;

                    if (string.IsNullOrEmpty(Item.Text)
                        && Item.DataBindings != null
                        && Item.DataBindings["Text"] != null
                        )
                    {
                        PropertyInfo PropertyInfo
                            = Item.ComboBoxItem.GetType().GetProperty(
                                Item.DataBindings["Text"].BindingMemberInfo.BindingMember);
                        Text = (string)PropertyInfo.GetValue(Item.ComboBoxItem, null);
                    }
                    else
                        Text = Item.Text;
                    if (Text.CompareTo(displayName) == 0)
                        return Item;
                }
                throw new ArgumentOutOfRangeException(String.Format("\"{0}\" does not exist in this combo box.", displayName));
            }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CheckBoxProperties
    {
        public CheckBoxProperties() { }

        private Appearance _Appearance = Appearance.Normal;
        private bool _AutoSize = false;
        private bool _AutoCheck = true;
        private bool _AutoEllipsis = false;
        private ContentAlignment _CheckAlign = ContentAlignment.MiddleLeft;
        private Color _FlatAppearanceBorderColor = Color.Empty;
        private int _FlatAppearanceBorderSize = 1;
        private Color _FlatAppearanceCheckedBackColor = Color.Empty;
        private Color _FlatAppearanceMouseDownBackColor = Color.Empty;
        private Color _FlatAppearanceMouseOverBackColor = Color.Empty;
        private FlatStyle _FlatStyle = FlatStyle.Standard;
        private Color _ForeColor = SystemColors.ControlText;
        private RightToLeft _RightToLeft = RightToLeft.No;
        private ContentAlignment _TextAlign = ContentAlignment.MiddleLeft;
        private bool _ThreeState = false;

        [DefaultValue(Appearance.Normal)]
        public Appearance Appearance
        {
            get { return _Appearance; }
            set { _Appearance = value; OnPropertyChanged(); }
        }
        [DefaultValue(true)]
        public bool AutoCheck
        {
            get { return _AutoCheck; }
            set { _AutoCheck = value; OnPropertyChanged(); }
        }
        [DefaultValue(false)]
        public bool AutoEllipsis
        {
            get { return _AutoEllipsis; }
            set { _AutoEllipsis = value; OnPropertyChanged(); }
        }
        [DefaultValue(false)]
        public bool AutoSize
        {
            get { return _AutoSize; }
            set { _AutoSize = true; OnPropertyChanged(); }
        }
        [DefaultValue(ContentAlignment.MiddleLeft)]
        public ContentAlignment CheckAlign
        {
            get { return _CheckAlign; }
            set { _CheckAlign = value; OnPropertyChanged(); }
        }
        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceBorderColor
        {
            get { return _FlatAppearanceBorderColor; }
            set { _FlatAppearanceBorderColor = value; OnPropertyChanged(); }
        }
        [DefaultValue(1)]
        public int FlatAppearanceBorderSize
        {
            get { return _FlatAppearanceBorderSize; }
            set { _FlatAppearanceBorderSize = value; OnPropertyChanged(); }
        }
        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceCheckedBackColor
        {
            get { return _FlatAppearanceCheckedBackColor; }
            set { _FlatAppearanceCheckedBackColor = value; OnPropertyChanged(); }
        }
        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceMouseDownBackColor
        {
            get { return _FlatAppearanceMouseDownBackColor; }
            set { _FlatAppearanceMouseDownBackColor = value; OnPropertyChanged(); }
        }
        [DefaultValue(typeof(Color), "")]
        public Color FlatAppearanceMouseOverBackColor
        {
            get { return _FlatAppearanceMouseOverBackColor; }
            set { _FlatAppearanceMouseOverBackColor = value; OnPropertyChanged(); }
        }
        [DefaultValue(FlatStyle.Standard)]
        public FlatStyle FlatStyle
        {
            get { return _FlatStyle; }
            set { _FlatStyle = value; OnPropertyChanged(); }
        }
        [DefaultValue(typeof(SystemColors), "ControlText")]
        public Color ForeColor
        {
            get { return _ForeColor; }
            set { _ForeColor = value; OnPropertyChanged(); }
        }
        [DefaultValue(RightToLeft.No)]
        public RightToLeft RightToLeft
        {
            get { return _RightToLeft; }
            set { _RightToLeft = value; OnPropertyChanged(); }
        }
        [DefaultValue(ContentAlignment.MiddleLeft)]
        public ContentAlignment TextAlign
        {
            get { return _TextAlign; }
            set { _TextAlign = value; OnPropertyChanged(); }
        }
        [DefaultValue(false)]
        public bool ThreeState
        {
            get { return _ThreeState; }
            set { _ThreeState = value; OnPropertyChanged(); }
        }

        public event EventHandler PropertyChanged;

        protected void OnPropertyChanged()
        {
            EventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}
