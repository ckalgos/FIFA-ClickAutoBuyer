
namespace FIFAAutoBuyer_Client.Forms
{
    partial class SettingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingList));
            this.grd_settingsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_SettingForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_editCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editSave = new Guna.UI2.WinForms.Guna2Button();
            this.txt_listPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.chk_sellAllCards = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chk_sellBoughtCard = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txt_settingSaveName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_buyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.trans_settingList = new Guna.UI2.WinForms.Guna2Transition(); 
            this.btn_editSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deleteSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btn_newSetting = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_noSettings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.trans_settingForm = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.grd_settingsList)).BeginInit();
            this.panel_SettingForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_settingsList
            // 
            this.grd_settingsList.AllowUserToAddRows = false;
            this.grd_settingsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grd_settingsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_settingsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_settingsList.BackgroundColor = System.Drawing.Color.White;
            this.grd_settingsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_settingsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_settingsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_settingsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_settingsList.ColumnHeadersHeight = 40;
            this.trans_settingForm.SetDecoration(this.grd_settingsList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.grd_settingsList, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_settingsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grd_settingsList.EnableHeadersVisualStyles = false;
            this.grd_settingsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_settingsList.Location = new System.Drawing.Point(23, 12);
            this.grd_settingsList.MultiSelect = false;
            this.grd_settingsList.Name = "grd_settingsList";
            this.grd_settingsList.ReadOnly = true;
            this.grd_settingsList.RowHeadersVisible = false;
            this.grd_settingsList.RowTemplate.DividerHeight = 5;
            this.grd_settingsList.RowTemplate.Height = 50;
            this.grd_settingsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_settingsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_settingsList.Size = new System.Drawing.Size(964, 338);
            this.grd_settingsList.TabIndex = 1;
            this.grd_settingsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grd_settingsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_settingsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_settingsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_settingsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_settingsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_settingsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_settingsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_settingsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_settingsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_settingsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_settingsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.grd_settingsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_settingsList.ThemeStyle.HeaderStyle.Height = 40;
            this.grd_settingsList.ThemeStyle.ReadOnly = true;
            this.grd_settingsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_settingsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_settingsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_settingsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_settingsList.ThemeStyle.RowsStyle.Height = 50;
            this.grd_settingsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grd_settingsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grd_settingsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grd_settingList_DataBindingComplete);
            this.grd_settingsList.SelectionChanged += new System.EventHandler(this.grd_settingList_SelectionChanged);
            // 
            // panel_SettingForm
            // 
            this.panel_SettingForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_SettingForm.BorderRadius = 8;
            this.panel_SettingForm.BorderThickness = 1;
            this.panel_SettingForm.Controls.Add(this.btn_editCancel);
            this.panel_SettingForm.Controls.Add(this.btn_editSave);
            this.panel_SettingForm.Controls.Add(this.txt_listPrice);
            this.panel_SettingForm.Controls.Add(this.chk_sellAllCards);
            this.panel_SettingForm.Controls.Add(this.chk_sellBoughtCard);
            this.panel_SettingForm.Controls.Add(this.txt_settingSaveName);
            this.panel_SettingForm.Controls.Add(this.txt_buyPrice);
            this.trans_settingForm.SetDecoration(this.panel_SettingForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.panel_SettingForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_SettingForm.Location = new System.Drawing.Point(264, 356);
            this.panel_SettingForm.Name = "panel_SettingForm";
            this.panel_SettingForm.ShadowDecoration.Parent = this.panel_SettingForm;
            this.panel_SettingForm.Size = new System.Drawing.Size(558, 285);
            this.panel_SettingForm.TabIndex = 4;
            this.panel_SettingForm.Visible = false;
            // 
            // btn_editCancel
            // 
            this.btn_editCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.BorderRadius = 3;
            this.btn_editCancel.BorderThickness = 1;
            this.btn_editCancel.CheckedState.Parent = this.btn_editCancel;
            this.btn_editCancel.CustomImages.Parent = this.btn_editCancel;
            this.trans_settingForm.SetDecoration(this.btn_editCancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.btn_editCancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editCancel.FillColor = System.Drawing.Color.Transparent;
            this.btn_editCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editCancel.ForeColor = System.Drawing.Color.Navy;
            this.btn_editCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editCancel.HoverState.Parent = this.btn_editCancel;
            this.btn_editCancel.Location = new System.Drawing.Point(80, 241);
            this.btn_editCancel.Name = "btn_editCancel";
            this.btn_editCancel.ShadowDecoration.Parent = this.btn_editCancel;
            this.btn_editCancel.Size = new System.Drawing.Size(165, 30);
            this.btn_editCancel.TabIndex = 62;
            this.btn_editCancel.Text = "Cancel";
            this.btn_editCancel.Click += new System.EventHandler(this.btn_editCancel_Click);
            // 
            // btn_editSave
            // 
            this.btn_editSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSave.BorderRadius = 3;
            this.btn_editSave.BorderThickness = 1;
            this.btn_editSave.CheckedState.Parent = this.btn_editSave;
            this.btn_editSave.CustomImages.Parent = this.btn_editSave;
            this.trans_settingForm.SetDecoration(this.btn_editSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.btn_editSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editSave.FillColor = System.Drawing.Color.Transparent;
            this.btn_editSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editSave.ForeColor = System.Drawing.Color.Navy;
            this.btn_editSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editSave.HoverState.Parent = this.btn_editSave;
            this.btn_editSave.Location = new System.Drawing.Point(323, 241);
            this.btn_editSave.Name = "btn_editSave";
            this.btn_editSave.ShadowDecoration.Parent = this.btn_editSave;
            this.btn_editSave.Size = new System.Drawing.Size(165, 30);
            this.btn_editSave.TabIndex = 61;
            this.btn_editSave.Text = "Save";
            this.btn_editSave.Click += new System.EventHandler(this.btn_editSave_Click);
            // 
            // txt_listPrice
            // 
            this.txt_listPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_listPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_settingForm.SetDecoration(this.txt_listPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.txt_listPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_listPrice.DefaultText = "";
            this.txt_listPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_listPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_listPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_listPrice.DisabledState.Parent = this.txt_listPrice;
            this.txt_listPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_listPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_listPrice.FocusedState.Parent = this.txt_listPrice;
            this.txt_listPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_listPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_listPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_listPrice.HoverState.Parent = this.txt_listPrice;
            this.txt_listPrice.Location = new System.Drawing.Point(159, 69);
            this.txt_listPrice.Name = "txt_listPrice";
            this.txt_listPrice.PasswordChar = '\0';
            this.txt_listPrice.PlaceholderText = "Sale Price";
            this.txt_listPrice.SelectedText = "";
            this.txt_listPrice.ShadowDecoration.Parent = this.txt_listPrice;
            this.txt_listPrice.Size = new System.Drawing.Size(224, 36);
            this.txt_listPrice.TabIndex = 60;
            this.txt_listPrice.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // chk_sellAllCards
            // 
            this.chk_sellAllCards.AutoSize = true;
            this.chk_sellAllCards.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_sellAllCards.CheckedState.BorderRadius = 0;
            this.chk_sellAllCards.CheckedState.BorderThickness = 0;
            this.chk_sellAllCards.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trans_settingForm.SetDecoration(this.chk_sellAllCards, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.chk_sellAllCards, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chk_sellAllCards.Location = new System.Drawing.Point(89, 126);
            this.chk_sellAllCards.Name = "chk_sellAllCards";
            this.chk_sellAllCards.Size = new System.Drawing.Size(132, 17);
            this.chk_sellAllCards.TabIndex = 59;
            this.chk_sellAllCards.Text = "Sell Transfer List Items";
            this.chk_sellAllCards.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_sellAllCards.UncheckedState.BorderRadius = 0;
            this.chk_sellAllCards.UncheckedState.BorderThickness = 0;
            this.chk_sellAllCards.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_sellAllCards.UseVisualStyleBackColor = false;
            // 
            // chk_sellBoughtCard
            // 
            this.chk_sellBoughtCard.AutoSize = true;
            this.chk_sellBoughtCard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_sellBoughtCard.CheckedState.BorderRadius = 0;
            this.chk_sellBoughtCard.CheckedState.BorderThickness = 0;
            this.chk_sellBoughtCard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trans_settingForm.SetDecoration(this.chk_sellBoughtCard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.chk_sellBoughtCard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chk_sellBoughtCard.Location = new System.Drawing.Point(355, 126);
            this.chk_sellBoughtCard.Name = "chk_sellBoughtCard";
            this.chk_sellBoughtCard.Size = new System.Drawing.Size(105, 17);
            this.chk_sellBoughtCard.TabIndex = 58;
            this.chk_sellBoughtCard.Text = "Sell Bought Card";
            this.chk_sellBoughtCard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_sellBoughtCard.UncheckedState.BorderRadius = 0;
            this.chk_sellBoughtCard.UncheckedState.BorderThickness = 0;
            this.chk_sellBoughtCard.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_sellBoughtCard.UseVisualStyleBackColor = false;
            // 
            // txt_settingSaveName
            // 
            this.txt_settingSaveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_settingSaveName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_settingForm.SetDecoration(this.txt_settingSaveName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.txt_settingSaveName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_settingSaveName.DefaultText = "";
            this.txt_settingSaveName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_settingSaveName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_settingSaveName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_settingSaveName.DisabledState.Parent = this.txt_settingSaveName;
            this.txt_settingSaveName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_settingSaveName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_settingSaveName.FocusedState.Parent = this.txt_settingSaveName;
            this.txt_settingSaveName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_settingSaveName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_settingSaveName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_settingSaveName.HoverState.Parent = this.txt_settingSaveName;
            this.txt_settingSaveName.Location = new System.Drawing.Point(159, 171);
            this.txt_settingSaveName.Name = "txt_settingSaveName";
            this.txt_settingSaveName.PasswordChar = '\0';
            this.txt_settingSaveName.PlaceholderText = "Setting Name";
            this.txt_settingSaveName.SelectedText = "";
            this.txt_settingSaveName.ShadowDecoration.Parent = this.txt_settingSaveName;
            this.txt_settingSaveName.Size = new System.Drawing.Size(224, 36);
            this.txt_settingSaveName.TabIndex = 57;
            this.txt_settingSaveName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txt_buyPrice
            // 
            this.txt_buyPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_buyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_settingForm.SetDecoration(this.txt_buyPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.txt_buyPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_buyPrice.DefaultText = "";
            this.txt_buyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_buyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_buyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_buyPrice.DisabledState.Parent = this.txt_buyPrice;
            this.txt_buyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_buyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_buyPrice.FocusedState.Parent = this.txt_buyPrice;
            this.txt_buyPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_buyPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_buyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_buyPrice.HoverState.Parent = this.txt_buyPrice;
            this.txt_buyPrice.Location = new System.Drawing.Point(159, 12);
            this.txt_buyPrice.Name = "txt_buyPrice";
            this.txt_buyPrice.PasswordChar = '\0';
            this.txt_buyPrice.PlaceholderText = "Buy Price";
            this.txt_buyPrice.SelectedText = "";
            this.txt_buyPrice.ShadowDecoration.Parent = this.txt_buyPrice;
            this.txt_buyPrice.Size = new System.Drawing.Size(224, 36);
            this.txt_buyPrice.TabIndex = 55;
            this.txt_buyPrice.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // trans_settingList
            // 
            this.trans_settingList.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.trans_settingList.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.trans_settingList.DefaultAnimation = animation2;
            this.trans_settingList.TimeStep = 1F; 
            // 
            // btn_editSetting
            // 
            this.btn_editSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSetting.BorderRadius = 3;
            this.btn_editSetting.BorderThickness = 1;
            this.btn_editSetting.CheckedState.Parent = this.btn_editSetting;
            this.btn_editSetting.CustomImages.Parent = this.btn_editSetting;
            this.trans_settingForm.SetDecoration(this.btn_editSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.btn_editSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editSetting.FillColor = System.Drawing.Color.Transparent;
            this.btn_editSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editSetting.ForeColor = System.Drawing.Color.Navy;
            this.btn_editSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSetting.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editSetting.HoverState.Parent = this.btn_editSetting;
            this.btn_editSetting.Location = new System.Drawing.Point(797, 659);
            this.btn_editSetting.Name = "btn_editSetting";
            this.btn_editSetting.ShadowDecoration.Parent = this.btn_editSetting;
            this.btn_editSetting.Size = new System.Drawing.Size(84, 30);
            this.btn_editSetting.TabIndex = 8;
            this.btn_editSetting.Text = "Edit";
            this.btn_editSetting.Visible = false;
            this.btn_editSetting.Click += new System.EventHandler(this.btn_editSetting_Click);
            // 
            // btn_deleteSetting
            // 
            this.btn_deleteSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deleteSetting.BorderRadius = 3;
            this.btn_deleteSetting.BorderThickness = 1;
            this.btn_deleteSetting.CheckedState.Parent = this.btn_deleteSetting;
            this.btn_deleteSetting.CustomImages.Parent = this.btn_deleteSetting;
            this.trans_settingForm.SetDecoration(this.btn_deleteSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.btn_deleteSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_deleteSetting.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteSetting.ForeColor = System.Drawing.Color.Navy;
            this.btn_deleteSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deleteSetting.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteSetting.HoverState.Parent = this.btn_deleteSetting;
            this.btn_deleteSetting.Location = new System.Drawing.Point(695, 659);
            this.btn_deleteSetting.Name = "btn_deleteSetting";
            this.btn_deleteSetting.ShadowDecoration.Parent = this.btn_deleteSetting;
            this.btn_deleteSetting.Size = new System.Drawing.Size(84, 30);
            this.btn_deleteSetting.TabIndex = 7;
            this.btn_deleteSetting.Text = "Delete";
            this.btn_deleteSetting.Visible = false;
            this.btn_deleteSetting.Click += new System.EventHandler(this.btn_deleteSetting_Click);
            // 
            // btn_newSetting
            // 
            this.btn_newSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_newSetting.BorderRadius = 3;
            this.btn_newSetting.BorderThickness = 1;
            this.btn_newSetting.CheckedState.Parent = this.btn_newSetting;
            this.btn_newSetting.CustomImages.Parent = this.btn_newSetting;
            this.trans_settingForm.SetDecoration(this.btn_newSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.btn_newSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_newSetting.FillColor = System.Drawing.Color.Transparent;
            this.btn_newSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_newSetting.ForeColor = System.Drawing.Color.Navy;
            this.btn_newSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_newSetting.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_newSetting.HoverState.Parent = this.btn_newSetting;
            this.btn_newSetting.Location = new System.Drawing.Point(898, 659);
            this.btn_newSetting.Name = "btn_newSetting";
            this.btn_newSetting.ShadowDecoration.Parent = this.btn_newSetting;
            this.btn_newSetting.Size = new System.Drawing.Size(84, 30);
            this.btn_newSetting.TabIndex = 6;
            this.btn_newSetting.Text = "New";
            this.btn_newSetting.Click += new System.EventHandler(this.btn_newSetting_Click);
            // 
            // lbl_noSettings
            // 
            this.lbl_noSettings.BackColor = System.Drawing.Color.Transparent;
            this.trans_settingForm.SetDecoration(this.lbl_noSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this.lbl_noSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_noSettings.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noSettings.Location = new System.Drawing.Point(436, 128);
            this.lbl_noSettings.Name = "lbl_noSettings";
            this.lbl_noSettings.Size = new System.Drawing.Size(127, 23);
            this.lbl_noSettings.TabIndex = 9;
            this.lbl_noSettings.Text = "No Settings Found";
            this.lbl_noSettings.Visible = false;
            // 
            // trans_settingForm
            // 
            this.trans_settingForm.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.trans_settingForm.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.trans_settingForm.DefaultAnimation = animation1;
            this.trans_settingForm.Interval = 50;
            this.trans_settingForm.TimeStep = 1F;
            // 
            // SettingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1011, 701);
            this.Controls.Add(this.lbl_noSettings);
            this.Controls.Add(this.btn_editSetting);
            this.Controls.Add(this.btn_deleteSetting);
            this.Controls.Add(this.btn_newSetting);
            this.Controls.Add(this.grd_settingsList);
            this.Controls.Add(this.panel_SettingForm);
            this.trans_settingForm.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_settingList.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingList";
            this.Text = "List";
            this.Load += new System.EventHandler(this.SettingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_settingsList)).EndInit();
            this.panel_SettingForm.ResumeLayout(false);
            this.panel_SettingForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView grd_settingsList;
        private Guna.UI2.WinForms.Guna2Panel panel_SettingForm;
        private Guna.UI2.WinForms.Guna2Transition trans_settingList;
        private Guna.UI2.WinForms.Guna2Transition trans_settingForm; 
        private Guna.UI2.WinForms.Guna2Button btn_editSetting;
        private Guna.UI2.WinForms.Guna2Button btn_deleteSetting;
        private Guna.UI2.WinForms.Guna2Button btn_newSetting;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_noSettings;
        private Guna.UI2.WinForms.Guna2TextBox txt_settingSaveName;
        private Guna.UI2.WinForms.Guna2TextBox txt_buyPrice;
        private Guna.UI2.WinForms.Guna2CheckBox chk_sellBoughtCard;
        private Guna.UI2.WinForms.Guna2CheckBox chk_sellAllCards;
        private Guna.UI2.WinForms.Guna2TextBox txt_listPrice;
        private Guna.UI2.WinForms.Guna2Button btn_editCancel;
        private Guna.UI2.WinForms.Guna2Button btn_editSave;
    }
}