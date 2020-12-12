
namespace FIFAAutoBuyer_Client.Forms
{
    partial class AccountList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            FIFAAutoBuyer_Client.UserControls.MultiSelect.CheckBoxProperties checkBoxProperties2 = new FIFAAutoBuyer_Client.UserControls.MultiSelect.CheckBoxProperties();
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountList));
            this.grd_accountList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_newUser = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.panel_EditForm = new Guna.UI2.WinForms.Guna2Panel();
            this.chk_hideBrowser = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lnk_newSearch = new MetroFramework.Controls.MetroLink();
            this.cmb_searches = new FIFAAutoBuyer_Client.UserControls.MultiSelect.MultiSelectComboBox();
            this.btn_editCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editSave = new Guna.UI2.WinForms.Guna2Button();
            this.txt_userGAuthKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_userPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_userEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.trans_accountList = new Guna.UI2.WinForms.Guna2Transition();
            this.btn_editUser = new Guna.UI2.WinForms.Guna2Button();
            this.btn_startAccount = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_noAccounts = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.progress_loader = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.trans_editUserForm = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.grd_accountList)).BeginInit();
            this.panel_EditForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_accountList
            // 
            this.grd_accountList.AllowUserToAddRows = false;
            this.grd_accountList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.grd_accountList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grd_accountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_accountList.BackgroundColor = System.Drawing.Color.White;
            this.grd_accountList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_accountList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_accountList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_accountList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grd_accountList.ColumnHeadersHeight = 40;
            this.trans_editUserForm.SetDecoration(this.grd_accountList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.grd_accountList, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_accountList.DefaultCellStyle = dataGridViewCellStyle7;
            this.grd_accountList.EnableHeadersVisualStyles = false;
            this.grd_accountList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_accountList.Location = new System.Drawing.Point(23, 12);
            this.grd_accountList.MultiSelect = false;
            this.grd_accountList.Name = "grd_accountList";
            this.grd_accountList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_accountList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_accountList.RowHeadersVisible = false;
            this.grd_accountList.RowTemplate.DividerHeight = 5;
            this.grd_accountList.RowTemplate.Height = 50;
            this.grd_accountList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_accountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_accountList.Size = new System.Drawing.Size(964, 332);
            this.grd_accountList.TabIndex = 1;
            this.grd_accountList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grd_accountList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_accountList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_accountList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_accountList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_accountList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_accountList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_accountList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_accountList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_accountList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_accountList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_accountList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.grd_accountList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_accountList.ThemeStyle.HeaderStyle.Height = 40;
            this.grd_accountList.ThemeStyle.ReadOnly = true;
            this.grd_accountList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_accountList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_accountList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_accountList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_accountList.ThemeStyle.RowsStyle.Height = 50;
            this.grd_accountList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grd_accountList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grd_accountList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grd_accountList_DataBindingComplete);
            this.grd_accountList.SelectionChanged += new System.EventHandler(this.grd_accountList_SelectionChanged);
            // 
            // btn_newUser
            // 
            this.btn_newUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_newUser.BorderRadius = 3;
            this.btn_newUser.BorderThickness = 1;
            this.btn_newUser.CheckedState.Parent = this.btn_newUser;
            this.btn_newUser.CustomImages.Parent = this.btn_newUser;
            this.trans_editUserForm.SetDecoration(this.btn_newUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.btn_newUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_newUser.FillColor = System.Drawing.Color.Transparent;
            this.btn_newUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_newUser.ForeColor = System.Drawing.Color.Navy;
            this.btn_newUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_newUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_newUser.HoverState.Parent = this.btn_newUser;
            this.btn_newUser.Location = new System.Drawing.Point(903, 650);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.ShadowDecoration.Parent = this.btn_newUser;
            this.btn_newUser.Size = new System.Drawing.Size(84, 30);
            this.btn_newUser.TabIndex = 2;
            this.btn_newUser.Text = "New";
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deleteUser.BorderRadius = 3;
            this.btn_deleteUser.BorderThickness = 1;
            this.btn_deleteUser.CheckedState.Parent = this.btn_deleteUser;
            this.btn_deleteUser.CustomImages.Parent = this.btn_deleteUser;
            this.trans_editUserForm.SetDecoration(this.btn_deleteUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.btn_deleteUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_deleteUser.FillColor = System.Drawing.Color.Transparent;
            this.btn_deleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteUser.ForeColor = System.Drawing.Color.Navy;
            this.btn_deleteUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deleteUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.HoverState.Parent = this.btn_deleteUser;
            this.btn_deleteUser.Location = new System.Drawing.Point(700, 650);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.ShadowDecoration.Parent = this.btn_deleteUser;
            this.btn_deleteUser.Size = new System.Drawing.Size(84, 30);
            this.btn_deleteUser.TabIndex = 3;
            this.btn_deleteUser.Text = "Delete";
            this.btn_deleteUser.Visible = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // panel_EditForm
            // 
            this.panel_EditForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_EditForm.BorderRadius = 8;
            this.panel_EditForm.BorderThickness = 1;
            this.panel_EditForm.Controls.Add(this.chk_hideBrowser);
            this.panel_EditForm.Controls.Add(this.lnk_newSearch);
            this.panel_EditForm.Controls.Add(this.cmb_searches);
            this.panel_EditForm.Controls.Add(this.btn_editCancel);
            this.panel_EditForm.Controls.Add(this.btn_editSave);
            this.panel_EditForm.Controls.Add(this.txt_userGAuthKey);
            this.panel_EditForm.Controls.Add(this.txt_userPassword);
            this.panel_EditForm.Controls.Add(this.txt_userEmail);
            this.trans_editUserForm.SetDecoration(this.panel_EditForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.panel_EditForm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_EditForm.Location = new System.Drawing.Point(251, 389);
            this.panel_EditForm.Name = "panel_EditForm";
            this.panel_EditForm.ShadowDecoration.Parent = this.panel_EditForm;
            this.panel_EditForm.Size = new System.Drawing.Size(507, 246);
            this.panel_EditForm.TabIndex = 4;
            this.panel_EditForm.Visible = false;
            // 
            // chk_hideBrowser
            // 
            this.chk_hideBrowser.AutoSize = true;
            this.chk_hideBrowser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_hideBrowser.CheckedState.BorderRadius = 0;
            this.chk_hideBrowser.CheckedState.BorderThickness = 0;
            this.chk_hideBrowser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trans_editUserForm.SetDecoration(this.chk_hideBrowser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.chk_hideBrowser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chk_hideBrowser.Location = new System.Drawing.Point(382, 122);
            this.chk_hideBrowser.Name = "chk_hideBrowser";
            this.chk_hideBrowser.Size = new System.Drawing.Size(89, 17);
            this.chk_hideBrowser.TabIndex = 64;
            this.chk_hideBrowser.Text = "Hide Browser";
            this.chk_hideBrowser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_hideBrowser.UncheckedState.BorderRadius = 0;
            this.chk_hideBrowser.UncheckedState.BorderThickness = 0;
            this.chk_hideBrowser.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_hideBrowser.UseVisualStyleBackColor = false;
            // 
            // lnk_newSearch
            // 
            this.lnk_newSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans_editUserForm.SetDecoration(this.lnk_newSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.lnk_newSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lnk_newSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lnk_newSearch.Location = new System.Drawing.Point(364, 151);
            this.lnk_newSearch.Name = "lnk_newSearch";
            this.lnk_newSearch.Size = new System.Drawing.Size(136, 23);
            this.lnk_newSearch.TabIndex = 13;
            this.lnk_newSearch.Text = "Create New Search";
            this.lnk_newSearch.UseCustomBackColor = true;
            this.lnk_newSearch.UseCustomForeColor = true;
            this.lnk_newSearch.UseSelectable = true;
            this.lnk_newSearch.Click += new System.EventHandler(this.lnk_newSearch_Click);
            // 
            // cmb_searches
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_searches.CheckBoxProperties = checkBoxProperties2;
            this.trans_editUserForm.SetDecoration(this.cmb_searches, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.cmb_searches, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmb_searches.DisplayMember = "DisplayValue";
            this.cmb_searches.DisplayMemberSingleItem = "DisplayValue";
            this.cmb_searches.FormattingEnabled = true;
            this.cmb_searches.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.cmb_searches.Location = new System.Drawing.Point(77, 145);
            this.cmb_searches.Name = "cmb_searches";
            this.cmb_searches.Size = new System.Drawing.Size(281, 29);
            this.cmb_searches.TabIndex = 9;
            this.cmb_searches.UseSelectable = true;
            this.cmb_searches.ValueMember = "IsChecked";
            // 
            // btn_editCancel
            // 
            this.btn_editCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.BorderRadius = 3;
            this.btn_editCancel.BorderThickness = 1;
            this.btn_editCancel.CheckedState.Parent = this.btn_editCancel;
            this.btn_editCancel.CustomImages.Parent = this.btn_editCancel;
            this.trans_editUserForm.SetDecoration(this.btn_editCancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.btn_editCancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editCancel.FillColor = System.Drawing.Color.Transparent;
            this.btn_editCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editCancel.ForeColor = System.Drawing.Color.Navy;
            this.btn_editCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editCancel.HoverState.Parent = this.btn_editCancel;
            this.btn_editCancel.Location = new System.Drawing.Point(120, 201);
            this.btn_editCancel.Name = "btn_editCancel";
            this.btn_editCancel.ShadowDecoration.Parent = this.btn_editCancel;
            this.btn_editCancel.Size = new System.Drawing.Size(84, 30);
            this.btn_editCancel.TabIndex = 12;
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
            this.trans_editUserForm.SetDecoration(this.btn_editSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.btn_editSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editSave.FillColor = System.Drawing.Color.Transparent;
            this.btn_editSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editSave.ForeColor = System.Drawing.Color.Navy;
            this.btn_editSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editSave.HoverState.Parent = this.btn_editSave;
            this.btn_editSave.Location = new System.Drawing.Point(263, 201);
            this.btn_editSave.Name = "btn_editSave";
            this.btn_editSave.ShadowDecoration.Parent = this.btn_editSave;
            this.btn_editSave.Size = new System.Drawing.Size(84, 30);
            this.btn_editSave.TabIndex = 10;
            this.btn_editSave.Text = "Save";
            this.btn_editSave.Click += new System.EventHandler(this.btn_editSave_Click);
            // 
            // txt_userGAuthKey
            // 
            this.txt_userGAuthKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_userGAuthKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_editUserForm.SetDecoration(this.txt_userGAuthKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.txt_userGAuthKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_userGAuthKey.DefaultText = "";
            this.txt_userGAuthKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_userGAuthKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_userGAuthKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userGAuthKey.DisabledState.Parent = this.txt_userGAuthKey;
            this.txt_userGAuthKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userGAuthKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userGAuthKey.FocusedState.Parent = this.txt_userGAuthKey;
            this.txt_userGAuthKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_userGAuthKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_userGAuthKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userGAuthKey.HoverState.Parent = this.txt_userGAuthKey;
            this.txt_userGAuthKey.Location = new System.Drawing.Point(77, 103);
            this.txt_userGAuthKey.Name = "txt_userGAuthKey";
            this.txt_userGAuthKey.PasswordChar = '\0';
            this.txt_userGAuthKey.PlaceholderText = "GAuth Key";
            this.txt_userGAuthKey.SelectedText = "";
            this.txt_userGAuthKey.ShadowDecoration.Parent = this.txt_userGAuthKey;
            this.txt_userGAuthKey.Size = new System.Drawing.Size(281, 36);
            this.txt_userGAuthKey.TabIndex = 8;
            this.txt_userGAuthKey.UseSystemPasswordChar = true;
            // 
            // txt_userPassword
            // 
            this.txt_userPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_userPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_editUserForm.SetDecoration(this.txt_userPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.txt_userPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_userPassword.DefaultText = "";
            this.txt_userPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_userPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_userPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userPassword.DisabledState.Parent = this.txt_userPassword;
            this.txt_userPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userPassword.FocusedState.Parent = this.txt_userPassword;
            this.txt_userPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_userPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_userPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userPassword.HoverState.Parent = this.txt_userPassword;
            this.txt_userPassword.Location = new System.Drawing.Point(77, 61);
            this.txt_userPassword.Name = "txt_userPassword";
            this.txt_userPassword.PasswordChar = '\0';
            this.txt_userPassword.PlaceholderText = "Password";
            this.txt_userPassword.SelectedText = "";
            this.txt_userPassword.ShadowDecoration.Parent = this.txt_userPassword;
            this.txt_userPassword.Size = new System.Drawing.Size(281, 36);
            this.txt_userPassword.TabIndex = 3;
            this.txt_userPassword.UseSystemPasswordChar = true;
            // 
            // txt_userEmail
            // 
            this.txt_userEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_userEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_editUserForm.SetDecoration(this.txt_userEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.txt_userEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_userEmail.DefaultText = "";
            this.txt_userEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_userEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_userEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userEmail.DisabledState.Parent = this.txt_userEmail;
            this.txt_userEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userEmail.FocusedState.Parent = this.txt_userEmail;
            this.txt_userEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_userEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_userEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userEmail.HoverState.Parent = this.txt_userEmail;
            this.txt_userEmail.Location = new System.Drawing.Point(77, 19);
            this.txt_userEmail.Name = "txt_userEmail";
            this.txt_userEmail.PasswordChar = '\0';
            this.txt_userEmail.PlaceholderText = "Email";
            this.txt_userEmail.SelectedText = "";
            this.txt_userEmail.ShadowDecoration.Parent = this.txt_userEmail;
            this.txt_userEmail.Size = new System.Drawing.Size(281, 36);
            this.txt_userEmail.TabIndex = 2;
            this.txt_userEmail.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // trans_accountList
            // 
            this.trans_accountList.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.trans_accountList.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.trans_accountList.DefaultAnimation = animation4;
            this.trans_accountList.TimeStep = 1F;
            // 
            // btn_editUser
            // 
            this.btn_editUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editUser.BorderRadius = 3;
            this.btn_editUser.BorderThickness = 1;
            this.btn_editUser.CheckedState.Parent = this.btn_editUser;
            this.btn_editUser.CustomImages.Parent = this.btn_editUser;
            this.trans_editUserForm.SetDecoration(this.btn_editUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.btn_editUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_editUser.FillColor = System.Drawing.Color.Transparent;
            this.btn_editUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editUser.ForeColor = System.Drawing.Color.Navy;
            this.btn_editUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editUser.HoverState.Parent = this.btn_editUser;
            this.btn_editUser.Location = new System.Drawing.Point(802, 650);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.ShadowDecoration.Parent = this.btn_editUser;
            this.btn_editUser.Size = new System.Drawing.Size(84, 30);
            this.btn_editUser.TabIndex = 5;
            this.btn_editUser.Text = "Edit";
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // btn_startAccount
            // 
            this.btn_startAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_startAccount.BorderRadius = 3;
            this.btn_startAccount.BorderThickness = 1;
            this.btn_startAccount.CheckedState.Parent = this.btn_startAccount;
            this.btn_startAccount.CustomImages.Parent = this.btn_startAccount;
            this.trans_editUserForm.SetDecoration(this.btn_startAccount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.btn_startAccount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_startAccount.FillColor = System.Drawing.Color.Transparent;
            this.btn_startAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_startAccount.ForeColor = System.Drawing.Color.Navy;
            this.btn_startAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_startAccount.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_startAccount.HoverState.Parent = this.btn_startAccount;
            this.btn_startAccount.Location = new System.Drawing.Point(87, 650);
            this.btn_startAccount.Name = "btn_startAccount";
            this.btn_startAccount.ShadowDecoration.Parent = this.btn_startAccount;
            this.btn_startAccount.Size = new System.Drawing.Size(84, 30);
            this.btn_startAccount.TabIndex = 6;
            this.btn_startAccount.Text = "Start Account";
            this.btn_startAccount.Visible = false;
            this.btn_startAccount.Click += new System.EventHandler(this.btn_startAccount_Click);
            // 
            // lbl_noAccounts
            // 
            this.lbl_noAccounts.BackColor = System.Drawing.Color.Transparent;
            this.trans_editUserForm.SetDecoration(this.lbl_noAccounts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.lbl_noAccounts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_noAccounts.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noAccounts.Location = new System.Drawing.Point(426, 110);
            this.lbl_noAccounts.Name = "lbl_noAccounts";
            this.lbl_noAccounts.Size = new System.Drawing.Size(134, 23);
            this.lbl_noAccounts.TabIndex = 7;
            this.lbl_noAccounts.Text = "No Accounts Found";
            this.lbl_noAccounts.Visible = false;
            // 
            // progress_loader
            // 
            this.progress_loader.BackColor = System.Drawing.Color.White;
            this.progress_loader.CircleSize = 1F;
            this.trans_editUserForm.SetDecoration(this.progress_loader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.progress_loader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.progress_loader.Location = new System.Drawing.Point(426, 202);
            this.progress_loader.Name = "progress_loader";
            this.progress_loader.Size = new System.Drawing.Size(141, 131);
            this.progress_loader.TabIndex = 8;
            this.progress_loader.Visible = false;
            // 
            // trans_editUserForm
            // 
            this.trans_editUserForm.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.trans_editUserForm.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.trans_editUserForm.DefaultAnimation = animation3;
            this.trans_editUserForm.Interval = 50;
            this.trans_editUserForm.TimeStep = 1F;
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1011, 701);
            this.Controls.Add(this.progress_loader);
            this.Controls.Add(this.lbl_noAccounts);
            this.Controls.Add(this.btn_startAccount);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.grd_accountList);
            this.Controls.Add(this.panel_EditForm);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.btn_newUser);
            this.trans_editUserForm.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountList";
            this.Text = "List";
            this.Load += new System.EventHandler(this.AccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_accountList)).EndInit();
            this.panel_EditForm.ResumeLayout(false);
            this.panel_EditForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView grd_accountList;
        private Guna.UI2.WinForms.Guna2Button btn_newUser;
        private Guna.UI2.WinForms.Guna2Button btn_deleteUser;
        private Guna.UI2.WinForms.Guna2Panel panel_EditForm;
        private Guna.UI2.WinForms.Guna2Button btn_editSave;
        private Guna.UI2.WinForms.Guna2TextBox txt_userGAuthKey;
        private Guna.UI2.WinForms.Guna2TextBox txt_userPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_userEmail;
        private Guna.UI2.WinForms.Guna2Transition trans_accountList;
        private Guna.UI2.WinForms.Guna2Transition trans_editUserForm;
        private Guna.UI2.WinForms.Guna2Button btn_editCancel; 
        private Guna.UI2.WinForms.Guna2Button btn_editUser;
        private Guna.UI2.WinForms.Guna2Button btn_startAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_noAccounts;
        private UserControls.MultiSelect.MultiSelectComboBox cmb_searches;
        private MetroFramework.Controls.MetroLink lnk_newSearch;
        private Guna.UI2.WinForms.Guna2CheckBox chk_hideBrowser;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progress_loader;
    }
}