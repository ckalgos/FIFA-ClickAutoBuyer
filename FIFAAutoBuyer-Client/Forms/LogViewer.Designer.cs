
namespace FIFAAutoBuyer_Client.Forms
{
    partial class LogViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewerForm));
            this.tab_userLogs = new MetroFramework.Controls.MetroTabControl();
            this.txt_searchTerm = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmb_types = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_clearLog = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // tab_userLogs
            // 
            this.tab_userLogs.Location = new System.Drawing.Point(12, 85);
            this.tab_userLogs.Name = "tab_userLogs";
            this.tab_userLogs.Size = new System.Drawing.Size(987, 604);
            this.tab_userLogs.TabIndex = 0;
            this.tab_userLogs.UseSelectable = true;
            this.tab_userLogs.SelectedIndexChanged += new System.EventHandler(this.tab_userLogs_SelectedIndexChanged);
            // 
            // txt_searchTerm
            // 
            this.txt_searchTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_searchTerm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchTerm.DefaultText = "";
            this.txt_searchTerm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchTerm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchTerm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchTerm.DisabledState.Parent = this.txt_searchTerm;
            this.txt_searchTerm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchTerm.FocusedState.Parent = this.txt_searchTerm;
            this.txt_searchTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_searchTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_searchTerm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchTerm.HoverState.Parent = this.txt_searchTerm;
            this.txt_searchTerm.Location = new System.Drawing.Point(217, 29);
            this.txt_searchTerm.Name = "txt_searchTerm";
            this.txt_searchTerm.PasswordChar = '\0';
            this.txt_searchTerm.PlaceholderText = "Search  Term";
            this.txt_searchTerm.SelectedText = "";
            this.txt_searchTerm.ShadowDecoration.Parent = this.txt_searchTerm;
            this.txt_searchTerm.Size = new System.Drawing.Size(281, 36);
            this.txt_searchTerm.TabIndex = 3;
            this.txt_searchTerm.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_search.CheckedState.Parent = this.btn_search;
            this.btn_search.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageRotate = 0F;
            this.btn_search.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_search.Location = new System.Drawing.Point(792, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_search.PressedState.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(38, 36);
            this.btn_search.TabIndex = 12;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_types
            // 
            this.cmb_types.BackColor = System.Drawing.Color.Transparent;
            this.cmb_types.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_types.DropDownWidth = 36;
            this.cmb_types.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_types.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_types.FocusedState.Parent = this.cmb_types;
            this.cmb_types.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_types.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_types.HoverState.Parent = this.cmb_types;
            this.cmb_types.IntegralHeight = false;
            this.cmb_types.ItemHeight = 30;
            this.cmb_types.Items.AddRange(new object[] {
            "-- Type --",
            "Trading",
            "Navigation",
            "Error"});
            this.cmb_types.ItemsAppearance.Parent = this.cmb_types;
            this.cmb_types.Location = new System.Drawing.Point(534, 29);
            this.cmb_types.Name = "cmb_types";
            this.cmb_types.ShadowDecoration.Parent = this.cmb_types;
            this.cmb_types.Size = new System.Drawing.Size(224, 36);
            this.cmb_types.StartIndex = 0;
            this.cmb_types.TabIndex = 34;
            // 
            // btn_clearLog
            // 
            this.btn_clearLog.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearLog.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_clearLog.CheckedState.Parent = this.btn_clearLog;
            this.btn_clearLog.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_clearLog.HoverState.Parent = this.btn_clearLog;
            this.btn_clearLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_clearLog.Image")));
            this.btn_clearLog.ImageRotate = 0F;
            this.btn_clearLog.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_clearLog.Location = new System.Drawing.Point(24, 29);
            this.btn_clearLog.Name = "btn_clearLog";
            this.btn_clearLog.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_clearLog.PressedState.Parent = this.btn_clearLog;
            this.btn_clearLog.Size = new System.Drawing.Size(38, 36);
            this.btn_clearLog.TabIndex = 35;
            this.btn_clearLog.Click += new System.EventHandler(this.btn_clearLog_Click);
            // 
            // LogViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 701);
            this.Controls.Add(this.btn_clearLog);
            this.Controls.Add(this.cmb_types);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchTerm);
            this.Controls.Add(this.tab_userLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogViewerForm";
            this.Text = "LogViewer";
            this.Load += new System.EventHandler(this.LogViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_userLogs;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchTerm;
        private Guna.UI2.WinForms.Guna2ImageButton btn_search;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_types;
        private Guna.UI2.WinForms.Guna2ImageButton btn_clearLog;
    }
}