
namespace FIFAAutoBuyer_Client.Forms
{
    partial class SearchList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation6 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchList));
            this.grd_searchList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_SearchForm = new Guna.UI2.WinForms.Guna2Panel();
            this.tab_searchOptions = new MetroFramework.Controls.MetroTabControl();
            this.tab_searchPlayer = new MetroFramework.Controls.MetroTabPage();
            this.cmb_abSettings = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_searchSaveName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ac_playerName = new FIFAAutoBuyer_Client.UserControls.AutoComplete();
            this.lbl_priceCriteria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_editCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editSave = new Guna.UI2.WinForms.Guna2Button();
            this.txt_srchPlayerBinMax = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_srchPlayerBinMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_srchPlayerBidMax = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_srchPlayerBidMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.sep_priceFilter = new Guna.UI2.WinForms.Guna2VSeparator();
            this.cmb_srchPlayerClub = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_srchPlayerLeague = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_srchPlayerNationality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_srchPlayerStyle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_srchPlayerPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_srchPlayerRarity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_srchPlayerQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.trans_searchList = new Guna.UI2.WinForms.Guna2Transition(); 
            this.btn_editSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deleteSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btn_newSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_noSearches = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.trans_searchForm = new Guna.UI2.WinForms.Guna2Transition();
            this.lnk_newSetting = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.grd_searchList)).BeginInit();
            this.panel_SearchForm.SuspendLayout();
            this.tab_searchOptions.SuspendLayout();
            this.tab_searchPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_searchList
            // 
            this.grd_searchList.AllowUserToAddRows = false;
            this.grd_searchList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grd_searchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grd_searchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_searchList.BackgroundColor = System.Drawing.Color.White;
            this.grd_searchList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_searchList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_searchList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_searchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_searchList.ColumnHeadersHeight = 40;
            this.trans_searchForm.SetDecoration(this.grd_searchList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.grd_searchList, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_searchList.DefaultCellStyle = dataGridViewCellStyle9;
            this.grd_searchList.EnableHeadersVisualStyles = false;
            this.grd_searchList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_searchList.Location = new System.Drawing.Point(23, 12);
            this.grd_searchList.MultiSelect = false;
            this.grd_searchList.Name = "grd_searchList";
            this.grd_searchList.ReadOnly = true;
            this.grd_searchList.RowHeadersVisible = false;
            this.grd_searchList.RowTemplate.DividerHeight = 5;
            this.grd_searchList.RowTemplate.Height = 50;
            this.grd_searchList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_searchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_searchList.Size = new System.Drawing.Size(964, 269);
            this.grd_searchList.TabIndex = 1;
            this.grd_searchList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grd_searchList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_searchList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_searchList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_searchList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_searchList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_searchList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_searchList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_searchList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_searchList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_searchList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_searchList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.grd_searchList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_searchList.ThemeStyle.HeaderStyle.Height = 40;
            this.grd_searchList.ThemeStyle.ReadOnly = true;
            this.grd_searchList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_searchList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_searchList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_searchList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_searchList.ThemeStyle.RowsStyle.Height = 50;
            this.grd_searchList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grd_searchList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grd_searchList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grd_searchList_DataBindingComplete);
            this.grd_searchList.SelectionChanged += new System.EventHandler(this.grd_searchList_SelectionChanged);
            // 
            // panel_SearchForm
            // 
            this.panel_SearchForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_SearchForm.BorderRadius = 8;
            this.panel_SearchForm.BorderThickness = 1;
            this.panel_SearchForm.Controls.Add(this.tab_searchOptions);
            this.trans_searchForm.SetDecoration(this.panel_SearchForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.panel_SearchForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_SearchForm.Location = new System.Drawing.Point(33, 287);
            this.panel_SearchForm.Name = "panel_SearchForm";
            this.panel_SearchForm.ShadowDecoration.Parent = this.panel_SearchForm;
            this.panel_SearchForm.Size = new System.Drawing.Size(940, 357);
            this.panel_SearchForm.TabIndex = 4;
            this.panel_SearchForm.Visible = false;
            // 
            // tab_searchOptions
            // 
            this.tab_searchOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_searchOptions.Controls.Add(this.tab_searchPlayer);
            this.trans_searchList.SetDecoration(this.tab_searchOptions, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchForm.SetDecoration(this.tab_searchOptions, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tab_searchOptions.Location = new System.Drawing.Point(3, 3);
            this.tab_searchOptions.Name = "tab_searchOptions";
            this.tab_searchOptions.SelectedIndex = 0;
            this.tab_searchOptions.Size = new System.Drawing.Size(934, 351);
            this.tab_searchOptions.TabIndex = 27;
            this.tab_searchOptions.UseCustomBackColor = true;
            this.tab_searchOptions.UseCustomForeColor = true;
            this.tab_searchOptions.UseSelectable = true;
            // 
            // tab_searchPlayer
            // 
            this.tab_searchPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.tab_searchPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_searchPlayer.Controls.Add(this.lnk_newSetting);
            this.tab_searchPlayer.Controls.Add(this.cmb_abSettings);
            this.tab_searchPlayer.Controls.Add(this.txt_searchSaveName);
            this.tab_searchPlayer.Controls.Add(this.ac_playerName);
            this.tab_searchPlayer.Controls.Add(this.lbl_priceCriteria);
            this.tab_searchPlayer.Controls.Add(this.btn_editCancel);
            this.tab_searchPlayer.Controls.Add(this.btn_editSave);
            this.tab_searchPlayer.Controls.Add(this.txt_srchPlayerBinMax);
            this.tab_searchPlayer.Controls.Add(this.txt_srchPlayerBinMin);
            this.tab_searchPlayer.Controls.Add(this.txt_srchPlayerBidMax);
            this.tab_searchPlayer.Controls.Add(this.txt_srchPlayerBidMin);
            this.tab_searchPlayer.Controls.Add(this.sep_priceFilter);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerClub);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerLeague);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerNationality);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerStyle);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerPosition);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerRarity);
            this.tab_searchPlayer.Controls.Add(this.cmb_srchPlayerQuality);
            this.trans_searchForm.SetDecoration(this.tab_searchPlayer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.tab_searchPlayer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tab_searchPlayer.HorizontalScrollbarBarColor = true;
            this.tab_searchPlayer.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_searchPlayer.HorizontalScrollbarSize = 10;
            this.tab_searchPlayer.Location = new System.Drawing.Point(4, 41);
            this.tab_searchPlayer.Name = "tab_searchPlayer";
            this.tab_searchPlayer.Size = new System.Drawing.Size(926, 306);
            this.tab_searchPlayer.TabIndex = 0;
            this.tab_searchPlayer.Text = "Players";
            this.tab_searchPlayer.UseCustomBackColor = true;
            this.tab_searchPlayer.UseCustomForeColor = true;
            this.tab_searchPlayer.VerticalScrollbarBarColor = true;
            this.tab_searchPlayer.VerticalScrollbarHighlightOnWheel = false;
            this.tab_searchPlayer.VerticalScrollbarSize = 10;
            // 
            // cmb_abSettings
            // 
            this.cmb_abSettings.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_abSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_abSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_abSettings.DisplayMember = "DisplayValue";
            this.cmb_abSettings.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_abSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_abSettings.DropDownWidth = 36;
            this.cmb_abSettings.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_abSettings.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_abSettings.FocusedState.Parent = this.cmb_abSettings;
            this.cmb_abSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_abSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_abSettings.HoverState.Parent = this.cmb_abSettings;
            this.cmb_abSettings.IntegralHeight = false;
            this.cmb_abSettings.ItemHeight = 30;
            this.cmb_abSettings.Items.AddRange(new object[] {
            "-- AB Setting --"});
            this.cmb_abSettings.ItemsAppearance.Parent = this.cmb_abSettings;
            this.cmb_abSettings.Location = new System.Drawing.Point(503, 165);
            this.cmb_abSettings.Name = "cmb_abSettings";
            this.cmb_abSettings.ShadowDecoration.Parent = this.cmb_abSettings;
            this.cmb_abSettings.Size = new System.Drawing.Size(224, 36);
            this.cmb_abSettings.StartIndex = 0;
            this.cmb_abSettings.TabIndex = 33;
            this.cmb_abSettings.ValueMember = "Id";
            // 
            // txt_searchSaveName
            // 
            this.txt_searchSaveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_searchSaveName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_searchForm.SetDecoration(this.txt_searchSaveName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.txt_searchSaveName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_searchSaveName.DefaultText = "";
            this.txt_searchSaveName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchSaveName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchSaveName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchSaveName.DisabledState.Parent = this.txt_searchSaveName;
            this.txt_searchSaveName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchSaveName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchSaveName.FocusedState.Parent = this.txt_searchSaveName;
            this.txt_searchSaveName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_searchSaveName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_searchSaveName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchSaveName.HoverState.Parent = this.txt_searchSaveName;
            this.txt_searchSaveName.Location = new System.Drawing.Point(587, 207);
            this.txt_searchSaveName.Name = "txt_searchSaveName";
            this.txt_searchSaveName.PasswordChar = '\0';
            this.txt_searchSaveName.PlaceholderText = "Search Name";
            this.txt_searchSaveName.SelectedText = "";
            this.txt_searchSaveName.ShadowDecoration.Parent = this.txt_searchSaveName;
            this.txt_searchSaveName.Size = new System.Drawing.Size(224, 36);
            this.txt_searchSaveName.TabIndex = 31;
            this.txt_searchSaveName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ac_playerName
            // 
            this.ac_playerName.BackColor = System.Drawing.Color.Transparent;
            this.ac_playerName.DataSource = ((System.Collections.Generic.List<string>)(resources.GetObject("ac_playerName.DataSource")));
            this.trans_searchForm.SetDecoration(this.ac_playerName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.ac_playerName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ac_playerName.Location = new System.Drawing.Point(39, 2);
            this.ac_playerName.Name = "ac_playerName";
            this.ac_playerName.PromptText = "Player Name";
            this.ac_playerName.Size = new System.Drawing.Size(344, 52);
            this.ac_playerName.TabIndex = 32;
            this.ac_playerName.UseCustomBackColor = true;
            this.ac_playerName.UseSelectable = true;
            // 
            // lbl_priceCriteria
            // 
            this.lbl_priceCriteria.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.lbl_priceCriteria, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.lbl_priceCriteria, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_priceCriteria.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priceCriteria.Location = new System.Drawing.Point(654, 24);
            this.lbl_priceCriteria.Name = "lbl_priceCriteria";
            this.lbl_priceCriteria.Size = new System.Drawing.Size(82, 23);
            this.lbl_priceCriteria.TabIndex = 25;
            this.lbl_priceCriteria.Text = "Price Filters";
            // 
            // btn_editCancel
            // 
            this.btn_editCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.BorderRadius = 3;
            this.btn_editCancel.BorderThickness = 1;
            this.btn_editCancel.CheckedState.Parent = this.btn_editCancel;
            this.btn_editCancel.CustomImages.Parent = this.btn_editCancel;
            this.trans_searchForm.SetDecoration(this.btn_editCancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.btn_editCancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editCancel.FillColor = System.Drawing.Color.Transparent;
            this.btn_editCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editCancel.ForeColor = System.Drawing.Color.Navy;
            this.btn_editCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editCancel.HoverState.Parent = this.btn_editCancel;
            this.btn_editCancel.Location = new System.Drawing.Point(235, 260);
            this.btn_editCancel.Name = "btn_editCancel";
            this.btn_editCancel.ShadowDecoration.Parent = this.btn_editCancel;
            this.btn_editCancel.Size = new System.Drawing.Size(165, 30);
            this.btn_editCancel.TabIndex = 24;
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
            this.trans_searchForm.SetDecoration(this.btn_editSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.btn_editSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editSave.FillColor = System.Drawing.Color.Transparent;
            this.btn_editSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editSave.ForeColor = System.Drawing.Color.Navy;
            this.btn_editSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editSave.HoverState.Parent = this.btn_editSave;
            this.btn_editSave.Location = new System.Drawing.Point(507, 260);
            this.btn_editSave.Name = "btn_editSave";
            this.btn_editSave.ShadowDecoration.Parent = this.btn_editSave;
            this.btn_editSave.Size = new System.Drawing.Size(165, 30);
            this.btn_editSave.TabIndex = 23;
            this.btn_editSave.Text = "Save";
            this.btn_editSave.Click += new System.EventHandler(this.btn_editSave_Click);
            // 
            // txt_srchPlayerBinMax
            // 
            this.txt_srchPlayerBinMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_srchPlayerBinMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_searchForm.SetDecoration(this.txt_srchPlayerBinMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.txt_srchPlayerBinMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_srchPlayerBinMax.DefaultText = "";
            this.txt_srchPlayerBinMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_srchPlayerBinMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_srchPlayerBinMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBinMax.DisabledState.Parent = this.txt_srchPlayerBinMax;
            this.txt_srchPlayerBinMax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBinMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBinMax.FocusedState.Parent = this.txt_srchPlayerBinMax;
            this.txt_srchPlayerBinMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_srchPlayerBinMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_srchPlayerBinMax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBinMax.HoverState.Parent = this.txt_srchPlayerBinMax;
            this.txt_srchPlayerBinMax.Location = new System.Drawing.Point(702, 102);
            this.txt_srchPlayerBinMax.Name = "txt_srchPlayerBinMax";
            this.txt_srchPlayerBinMax.PasswordChar = '\0';
            this.txt_srchPlayerBinMax.PlaceholderText = "BIN Max";
            this.txt_srchPlayerBinMax.SelectedText = "";
            this.txt_srchPlayerBinMax.ShadowDecoration.Parent = this.txt_srchPlayerBinMax;
            this.txt_srchPlayerBinMax.Size = new System.Drawing.Size(219, 36);
            this.txt_srchPlayerBinMax.TabIndex = 22;
            this.txt_srchPlayerBinMax.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txt_srchPlayerBinMin
            // 
            this.txt_srchPlayerBinMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_srchPlayerBinMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_searchForm.SetDecoration(this.txt_srchPlayerBinMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.txt_srchPlayerBinMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_srchPlayerBinMin.DefaultText = "";
            this.txt_srchPlayerBinMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_srchPlayerBinMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_srchPlayerBinMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBinMin.DisabledState.Parent = this.txt_srchPlayerBinMin;
            this.txt_srchPlayerBinMin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBinMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBinMin.FocusedState.Parent = this.txt_srchPlayerBinMin;
            this.txt_srchPlayerBinMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_srchPlayerBinMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_srchPlayerBinMin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBinMin.HoverState.Parent = this.txt_srchPlayerBinMin;
            this.txt_srchPlayerBinMin.Location = new System.Drawing.Point(482, 102);
            this.txt_srchPlayerBinMin.Name = "txt_srchPlayerBinMin";
            this.txt_srchPlayerBinMin.PasswordChar = '\0';
            this.txt_srchPlayerBinMin.PlaceholderText = "BIN Min";
            this.txt_srchPlayerBinMin.SelectedText = "";
            this.txt_srchPlayerBinMin.ShadowDecoration.Parent = this.txt_srchPlayerBinMin;
            this.txt_srchPlayerBinMin.Size = new System.Drawing.Size(204, 36);
            this.txt_srchPlayerBinMin.TabIndex = 21;
            this.txt_srchPlayerBinMin.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txt_srchPlayerBidMax
            // 
            this.txt_srchPlayerBidMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_srchPlayerBidMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_searchForm.SetDecoration(this.txt_srchPlayerBidMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.txt_srchPlayerBidMax, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_srchPlayerBidMax.DefaultText = "";
            this.txt_srchPlayerBidMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_srchPlayerBidMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_srchPlayerBidMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBidMax.DisabledState.Parent = this.txt_srchPlayerBidMax;
            this.txt_srchPlayerBidMax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBidMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBidMax.FocusedState.Parent = this.txt_srchPlayerBidMax;
            this.txt_srchPlayerBidMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_srchPlayerBidMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_srchPlayerBidMax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBidMax.HoverState.Parent = this.txt_srchPlayerBidMax;
            this.txt_srchPlayerBidMax.Location = new System.Drawing.Point(702, 60);
            this.txt_srchPlayerBidMax.Name = "txt_srchPlayerBidMax";
            this.txt_srchPlayerBidMax.PasswordChar = '\0';
            this.txt_srchPlayerBidMax.PlaceholderText = "Bid Max";
            this.txt_srchPlayerBidMax.SelectedText = "";
            this.txt_srchPlayerBidMax.ShadowDecoration.Parent = this.txt_srchPlayerBidMax;
            this.txt_srchPlayerBidMax.Size = new System.Drawing.Size(219, 36);
            this.txt_srchPlayerBidMax.TabIndex = 20;
            this.txt_srchPlayerBidMax.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txt_srchPlayerBidMin
            // 
            this.txt_srchPlayerBidMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_srchPlayerBidMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_searchForm.SetDecoration(this.txt_srchPlayerBidMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.txt_srchPlayerBidMin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_srchPlayerBidMin.DefaultText = "";
            this.txt_srchPlayerBidMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_srchPlayerBidMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_srchPlayerBidMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBidMin.DisabledState.Parent = this.txt_srchPlayerBidMin;
            this.txt_srchPlayerBidMin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchPlayerBidMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBidMin.FocusedState.Parent = this.txt_srchPlayerBidMin;
            this.txt_srchPlayerBidMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_srchPlayerBidMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_srchPlayerBidMin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchPlayerBidMin.HoverState.Parent = this.txt_srchPlayerBidMin;
            this.txt_srchPlayerBidMin.Location = new System.Drawing.Point(482, 60);
            this.txt_srchPlayerBidMin.Name = "txt_srchPlayerBidMin";
            this.txt_srchPlayerBidMin.PasswordChar = '\0';
            this.txt_srchPlayerBidMin.PlaceholderText = "Bid Min";
            this.txt_srchPlayerBidMin.SelectedText = "";
            this.txt_srchPlayerBidMin.ShadowDecoration.Parent = this.txt_srchPlayerBidMin;
            this.txt_srchPlayerBidMin.Size = new System.Drawing.Size(204, 36);
            this.txt_srchPlayerBidMin.TabIndex = 19;
            this.txt_srchPlayerBidMin.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // sep_priceFilter
            // 
            this.trans_searchList.SetDecoration(this.sep_priceFilter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchForm.SetDecoration(this.sep_priceFilter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sep_priceFilter.Location = new System.Drawing.Point(447, 13);
            this.sep_priceFilter.Name = "sep_priceFilter";
            this.sep_priceFilter.Size = new System.Drawing.Size(10, 230);
            this.sep_priceFilter.TabIndex = 18;
            // 
            // cmb_srchPlayerClub
            // 
            this.cmb_srchPlayerClub.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerClub, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerClub, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerClub.DisplayMember = "DisplayValue";
            this.cmb_srchPlayerClub.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerClub.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerClub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerClub.FocusedState.Parent = this.cmb_srchPlayerClub;
            this.cmb_srchPlayerClub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerClub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerClub.HoverState.Parent = this.cmb_srchPlayerClub;
            this.cmb_srchPlayerClub.IntegralHeight = false;
            this.cmb_srchPlayerClub.ItemHeight = 30;
            this.cmb_srchPlayerClub.Items.AddRange(new object[] {
            "-- Club --"});
            this.cmb_srchPlayerClub.ItemsAppearance.Parent = this.cmb_srchPlayerClub;
            this.cmb_srchPlayerClub.Location = new System.Drawing.Point(64, 187);
            this.cmb_srchPlayerClub.Name = "cmb_srchPlayerClub";
            this.cmb_srchPlayerClub.ShadowDecoration.Parent = this.cmb_srchPlayerClub;
            this.cmb_srchPlayerClub.Size = new System.Drawing.Size(318, 36);
            this.cmb_srchPlayerClub.StartIndex = 0;
            this.cmb_srchPlayerClub.TabIndex = 17;
            // 
            // cmb_srchPlayerLeague
            // 
            this.cmb_srchPlayerLeague.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerLeague, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerLeague, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerLeague.DisplayMember = "DisplayValue";
            this.cmb_srchPlayerLeague.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerLeague.DropDownWidth = 395;
            this.cmb_srchPlayerLeague.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerLeague.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerLeague.FocusedState.Parent = this.cmb_srchPlayerLeague;
            this.cmb_srchPlayerLeague.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerLeague.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerLeague.HoverState.Parent = this.cmb_srchPlayerLeague;
            this.cmb_srchPlayerLeague.IntegralHeight = false;
            this.cmb_srchPlayerLeague.ItemHeight = 30;
            this.cmb_srchPlayerLeague.Items.AddRange(new object[] {
            "-- League --"});
            this.cmb_srchPlayerLeague.ItemsAppearance.Parent = this.cmb_srchPlayerLeague;
            this.cmb_srchPlayerLeague.Location = new System.Drawing.Point(235, 145);
            this.cmb_srchPlayerLeague.Name = "cmb_srchPlayerLeague";
            this.cmb_srchPlayerLeague.ShadowDecoration.Parent = this.cmb_srchPlayerLeague;
            this.cmb_srchPlayerLeague.Size = new System.Drawing.Size(173, 36);
            this.cmb_srchPlayerLeague.StartIndex = 0;
            this.cmb_srchPlayerLeague.TabIndex = 16;
            this.cmb_srchPlayerLeague.SelectedIndexChanged += new System.EventHandler(this.cmb_srchPlayerLeague_SelectedIndexChanged);
            // 
            // cmb_srchPlayerNationality
            // 
            this.cmb_srchPlayerNationality.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerNationality, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerNationality, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerNationality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerNationality.FocusedState.Parent = this.cmb_srchPlayerNationality;
            this.cmb_srchPlayerNationality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerNationality.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerNationality.HoverState.Parent = this.cmb_srchPlayerNationality;
            this.cmb_srchPlayerNationality.IntegralHeight = false;
            this.cmb_srchPlayerNationality.ItemHeight = 30;
            this.cmb_srchPlayerNationality.Items.AddRange(new object[] {
            "-- Nationality -- ",
            "Argentina",
            "Brazil",
            "England",
            "France",
            "Germany",
            "Netherlands",
            "Italy",
            "Portugal",
            "Spain",
            "Afghanist.",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua B.",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bolivia",
            "Bosnia-H.",
            "Brazil",
            "Bulgaria",
            "Burk. Faso",
            "Burundi",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "CAR",
            "Chad",
            "Chile",
            "China PR",
            "Chinese Taipei",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Rep.",
            "Denmark",
            "Dom. Rep.",
            "DR Congo",
            "E. Guinea",
            "Ecuador",
            "Egypt",
            "El Salvad.",
            "England",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Faroe Isl.",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Grenada",
            "Guam",
            "Guinea",
            "Guinea-Bis",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Korea DPR",
            "Korea Rep.",
            "Kosovo",
            "Latvia",
            "Lebanon",
            "Liberia",
            "Libya",
            "Liechten.",
            "Lithuania",
            "Luxemburg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Mali",
            "Malta",
            "Mauritania",
            "Mexico",
            "Moldova",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "N. Ireland",
            "N.Antilles",
            "Namibia",
            "Netherlands",
            "New Caled.",
            "New Zealand",
            "Niger",
            "Nigeria",
            "Norway",
            "Palestinian Authority",
            "Panama",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Romania",
            "Russia",
            "Rwanda",
            "S. Africa",
            "São Tomé & Príncipe",
            "Saudi Ara.",
            "Scotland",
            "Senegal",
            "Serbia",
            "Sierra L.",
            "Slovakia",
            "Slovenia",
            "South Sudan",
            "Spain",
            "St Kitts Nevis",
            "St Lucia",
            "Sudan",
            "Sweden",
            "Switzerl.",
            "Syria",
            "Tanzania",
            "Thailand",
            "Togo",
            "Trinidad",
            "Tunisia",
            "Turkey",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "Uruguay",
            "USA",
            "Uzbekistan",
            "Venezuela",
            "Wales",
            "Zambia",
            "Zimbabwe"});
            this.cmb_srchPlayerNationality.ItemsAppearance.Parent = this.cmb_srchPlayerNationality;
            this.cmb_srchPlayerNationality.Location = new System.Drawing.Point(3, 145);
            this.cmb_srchPlayerNationality.Name = "cmb_srchPlayerNationality";
            this.cmb_srchPlayerNationality.ShadowDecoration.Parent = this.cmb_srchPlayerNationality;
            this.cmb_srchPlayerNationality.Size = new System.Drawing.Size(173, 36);
            this.cmb_srchPlayerNationality.StartIndex = 0;
            this.cmb_srchPlayerNationality.TabIndex = 15;
            // 
            // cmb_srchPlayerStyle
            // 
            this.cmb_srchPlayerStyle.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerStyle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerStyle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerStyle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerStyle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerStyle.FocusedState.Parent = this.cmb_srchPlayerStyle;
            this.cmb_srchPlayerStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerStyle.HoverState.Parent = this.cmb_srchPlayerStyle;
            this.cmb_srchPlayerStyle.IntegralHeight = false;
            this.cmb_srchPlayerStyle.ItemHeight = 30;
            this.cmb_srchPlayerStyle.Items.AddRange(new object[] {
            "-- Chemistry Style -- ",
            "BASIC",
            "SNIPER",
            "FINISHER",
            "DEADEYE",
            "MARKSMAN",
            "HAWK",
            "ARTIST",
            "ARCHITECT",
            "POWERHOUSE",
            "MAESTRO",
            "ENGINE",
            "SENTINEL",
            "GUARDIAN",
            "GLADIATOR",
            "BACKBONE",
            "ANCHOR",
            "HUNTER",
            "CATALYST",
            "SHADOW",
            "WALL",
            "SHIELD",
            "CAT",
            "GLOVE",
            "GK BASIC"});
            this.cmb_srchPlayerStyle.ItemsAppearance.Parent = this.cmb_srchPlayerStyle;
            this.cmb_srchPlayerStyle.Location = new System.Drawing.Point(235, 102);
            this.cmb_srchPlayerStyle.Name = "cmb_srchPlayerStyle";
            this.cmb_srchPlayerStyle.ShadowDecoration.Parent = this.cmb_srchPlayerStyle;
            this.cmb_srchPlayerStyle.Size = new System.Drawing.Size(173, 36);
            this.cmb_srchPlayerStyle.StartIndex = 0;
            this.cmb_srchPlayerStyle.TabIndex = 14;
            // 
            // cmb_srchPlayerPosition
            // 
            this.cmb_srchPlayerPosition.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerPosition, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerPosition, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerPosition.FocusedState.Parent = this.cmb_srchPlayerPosition;
            this.cmb_srchPlayerPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerPosition.HoverState.Parent = this.cmb_srchPlayerPosition;
            this.cmb_srchPlayerPosition.IntegralHeight = false;
            this.cmb_srchPlayerPosition.ItemHeight = 30;
            this.cmb_srchPlayerPosition.Items.AddRange(new object[] {
            "-- Position -- ",
            "Defenders",
            "Midfielders",
            "Attackers",
            "GK",
            "RWB",
            "RB",
            "CB",
            "LB",
            "LWB",
            "CDM",
            "RM",
            "CM",
            "LM",
            "CAM",
            "RF",
            "CF",
            "LF",
            "RW",
            "ST",
            "LW"});
            this.cmb_srchPlayerPosition.ItemsAppearance.Parent = this.cmb_srchPlayerPosition;
            this.cmb_srchPlayerPosition.Location = new System.Drawing.Point(3, 103);
            this.cmb_srchPlayerPosition.Name = "cmb_srchPlayerPosition";
            this.cmb_srchPlayerPosition.ShadowDecoration.Parent = this.cmb_srchPlayerPosition;
            this.cmb_srchPlayerPosition.Size = new System.Drawing.Size(173, 36);
            this.cmb_srchPlayerPosition.StartIndex = 0;
            this.cmb_srchPlayerPosition.TabIndex = 13;
            // 
            // cmb_srchPlayerRarity
            // 
            this.cmb_srchPlayerRarity.Animated = true;
            this.cmb_srchPlayerRarity.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerRarity, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerRarity, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerRarity.DisplayMember = "DisplayValue";
            this.cmb_srchPlayerRarity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerRarity.DropDownWidth = 395;
            this.cmb_srchPlayerRarity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerRarity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerRarity.FocusedState.Parent = this.cmb_srchPlayerRarity;
            this.cmb_srchPlayerRarity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerRarity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerRarity.HoverState.Parent = this.cmb_srchPlayerRarity;
            this.cmb_srchPlayerRarity.IntegralHeight = false;
            this.cmb_srchPlayerRarity.ItemHeight = 30;
            this.cmb_srchPlayerRarity.Items.AddRange(new object[] {
            "-- Rarity --"});
            this.cmb_srchPlayerRarity.ItemsAppearance.Parent = this.cmb_srchPlayerRarity;
            this.cmb_srchPlayerRarity.Location = new System.Drawing.Point(235, 61);
            this.cmb_srchPlayerRarity.Name = "cmb_srchPlayerRarity";
            this.cmb_srchPlayerRarity.ShadowDecoration.Parent = this.cmb_srchPlayerRarity;
            this.cmb_srchPlayerRarity.Size = new System.Drawing.Size(173, 36);
            this.cmb_srchPlayerRarity.StartIndex = 0;
            this.cmb_srchPlayerRarity.TabIndex = 12;
            // 
            // cmb_srchPlayerQuality
            // 
            this.cmb_srchPlayerQuality.Animated = true;
            this.cmb_srchPlayerQuality.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.cmb_srchPlayerQuality, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.cmb_srchPlayerQuality, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_srchPlayerQuality.DisplayMember = "DisplayValue";
            this.cmb_srchPlayerQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_srchPlayerQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_srchPlayerQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_srchPlayerQuality.FocusedState.Parent = this.cmb_srchPlayerQuality;
            this.cmb_srchPlayerQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_srchPlayerQuality.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_srchPlayerQuality.HoverState.Parent = this.cmb_srchPlayerQuality;
            this.cmb_srchPlayerQuality.IntegralHeight = false;
            this.cmb_srchPlayerQuality.ItemHeight = 30;
            this.cmb_srchPlayerQuality.Items.AddRange(new object[] {
            "-- Quality --"});
            this.cmb_srchPlayerQuality.ItemsAppearance.Parent = this.cmb_srchPlayerQuality;
            this.cmb_srchPlayerQuality.Location = new System.Drawing.Point(3, 61);
            this.cmb_srchPlayerQuality.Name = "cmb_srchPlayerQuality";
            this.cmb_srchPlayerQuality.ShadowDecoration.Parent = this.cmb_srchPlayerQuality;
            this.cmb_srchPlayerQuality.Size = new System.Drawing.Size(173, 36);
            this.cmb_srchPlayerQuality.StartIndex = 0;
            this.cmb_srchPlayerQuality.TabIndex = 10;
            this.cmb_srchPlayerQuality.SelectedIndexChanged += new System.EventHandler(this.cmb_srchPlayerQuality_SelectedIndexChanged);
            // 
            // trans_searchList
            // 
            this.trans_searchList.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.trans_searchList.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.trans_searchList.DefaultAnimation = animation6;
            this.trans_searchList.TimeStep = 1F; 
            // 
            // btn_editSearch
            // 
            this.btn_editSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSearch.BorderRadius = 3;
            this.btn_editSearch.BorderThickness = 1;
            this.btn_editSearch.CheckedState.Parent = this.btn_editSearch;
            this.btn_editSearch.CustomImages.Parent = this.btn_editSearch;
            this.trans_searchForm.SetDecoration(this.btn_editSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.btn_editSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editSearch.FillColor = System.Drawing.Color.Transparent;
            this.btn_editSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editSearch.ForeColor = System.Drawing.Color.Navy;
            this.btn_editSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editSearch.HoverState.Parent = this.btn_editSearch;
            this.btn_editSearch.Location = new System.Drawing.Point(797, 659);
            this.btn_editSearch.Name = "btn_editSearch";
            this.btn_editSearch.ShadowDecoration.Parent = this.btn_editSearch;
            this.btn_editSearch.Size = new System.Drawing.Size(84, 30);
            this.btn_editSearch.TabIndex = 8;
            this.btn_editSearch.Text = "Edit";
            this.btn_editSearch.Visible = false;
            this.btn_editSearch.Click += new System.EventHandler(this.btn_editSearch_Click);
            // 
            // btn_deleteSearch
            // 
            this.btn_deleteSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deleteSearch.BorderRadius = 3;
            this.btn_deleteSearch.BorderThickness = 1;
            this.btn_deleteSearch.CheckedState.Parent = this.btn_deleteSearch;
            this.btn_deleteSearch.CustomImages.Parent = this.btn_deleteSearch;
            this.trans_searchForm.SetDecoration(this.btn_deleteSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.btn_deleteSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_deleteSearch.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteSearch.ForeColor = System.Drawing.Color.Navy;
            this.btn_deleteSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deleteSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteSearch.HoverState.Parent = this.btn_deleteSearch;
            this.btn_deleteSearch.Location = new System.Drawing.Point(695, 659);
            this.btn_deleteSearch.Name = "btn_deleteSearch";
            this.btn_deleteSearch.ShadowDecoration.Parent = this.btn_deleteSearch;
            this.btn_deleteSearch.Size = new System.Drawing.Size(84, 30);
            this.btn_deleteSearch.TabIndex = 7;
            this.btn_deleteSearch.Text = "Delete";
            this.btn_deleteSearch.Visible = false;
            this.btn_deleteSearch.Click += new System.EventHandler(this.btn_deleteSearch_Click);
            // 
            // btn_newSearch
            // 
            this.btn_newSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_newSearch.BorderRadius = 3;
            this.btn_newSearch.BorderThickness = 1;
            this.btn_newSearch.CheckedState.Parent = this.btn_newSearch;
            this.btn_newSearch.CustomImages.Parent = this.btn_newSearch;
            this.trans_searchForm.SetDecoration(this.btn_newSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.btn_newSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_newSearch.FillColor = System.Drawing.Color.Transparent;
            this.btn_newSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_newSearch.ForeColor = System.Drawing.Color.Navy;
            this.btn_newSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_newSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_newSearch.HoverState.Parent = this.btn_newSearch;
            this.btn_newSearch.Location = new System.Drawing.Point(898, 659);
            this.btn_newSearch.Name = "btn_newSearch";
            this.btn_newSearch.ShadowDecoration.Parent = this.btn_newSearch;
            this.btn_newSearch.Size = new System.Drawing.Size(84, 30);
            this.btn_newSearch.TabIndex = 6;
            this.btn_newSearch.Text = "New";
            this.btn_newSearch.Click += new System.EventHandler(this.btn_newSearch_Click);
            // 
            // lbl_noSearches
            // 
            this.lbl_noSearches.BackColor = System.Drawing.Color.Transparent;
            this.trans_searchForm.SetDecoration(this.lbl_noSearches, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.lbl_noSearches, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_noSearches.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noSearches.Location = new System.Drawing.Point(400, 134);
            this.lbl_noSearches.Name = "lbl_noSearches";
            this.lbl_noSearches.Size = new System.Drawing.Size(179, 23);
            this.lbl_noSearches.TabIndex = 9;
            this.lbl_noSearches.Text = "No Search Criterias Found";
            this.lbl_noSearches.Visible = false;
            // 
            // trans_searchForm
            // 
            this.trans_searchForm.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.trans_searchForm.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.trans_searchForm.DefaultAnimation = animation5;
            this.trans_searchForm.Interval = 50;
            this.trans_searchForm.TimeStep = 1F;
            // 
            // lnk_newSetting
            // 
            this.lnk_newSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_searchForm.SetDecoration(this.lnk_newSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this.lnk_newSetting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lnk_newSetting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lnk_newSetting.Location = new System.Drawing.Point(746, 165);
            this.lnk_newSetting.Name = "lnk_newSetting";
            this.lnk_newSetting.Size = new System.Drawing.Size(136, 36);
            this.lnk_newSetting.TabIndex = 34;
            this.lnk_newSetting.Text = "Create New Setting";
            this.lnk_newSetting.UseCustomBackColor = true;
            this.lnk_newSetting.UseCustomForeColor = true;
            this.lnk_newSetting.UseSelectable = true;
            this.lnk_newSetting.Click += new System.EventHandler(this.lnk_newSetting_Click);
            // 
            // SearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1011, 701);
            this.Controls.Add(this.lbl_noSearches);
            this.Controls.Add(this.btn_editSearch);
            this.Controls.Add(this.btn_deleteSearch);
            this.Controls.Add(this.btn_newSearch);
            this.Controls.Add(this.grd_searchList);
            this.Controls.Add(this.panel_SearchForm);
            this.trans_searchForm.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_searchList.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchList";
            this.Text = "List";
            this.Load += new System.EventHandler(this.SearchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_searchList)).EndInit();
            this.panel_SearchForm.ResumeLayout(false);
            this.tab_searchOptions.ResumeLayout(false);
            this.tab_searchPlayer.ResumeLayout(false);
            this.tab_searchPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView grd_searchList;
        private Guna.UI2.WinForms.Guna2Panel panel_SearchForm;
        private Guna.UI2.WinForms.Guna2Transition trans_searchList;
        private Guna.UI2.WinForms.Guna2Transition trans_searchForm; 
        private MetroFramework.Controls.MetroTabControl tab_searchOptions;
        private MetroFramework.Controls.MetroTabPage tab_searchPlayer;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerQuality;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerRarity;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerStyle;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerLeague;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerNationality;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_srchPlayerClub;
        private Guna.UI2.WinForms.Guna2VSeparator sep_priceFilter;
        private Guna.UI2.WinForms.Guna2TextBox txt_srchPlayerBinMax;
        private Guna.UI2.WinForms.Guna2TextBox txt_srchPlayerBinMin;
        private Guna.UI2.WinForms.Guna2TextBox txt_srchPlayerBidMax;
        private Guna.UI2.WinForms.Guna2TextBox txt_srchPlayerBidMin;
        private Guna.UI2.WinForms.Guna2Button btn_editCancel;
        private Guna.UI2.WinForms.Guna2Button btn_editSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_priceCriteria;
        private Guna.UI2.WinForms.Guna2Button btn_editSearch;
        private Guna.UI2.WinForms.Guna2Button btn_deleteSearch;
        private Guna.UI2.WinForms.Guna2Button btn_newSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_noSearches;
        private UserControls.AutoComplete ac_playerName;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_abSettings;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchSaveName;
        private MetroFramework.Controls.MetroLink lnk_newSetting;
    }
}