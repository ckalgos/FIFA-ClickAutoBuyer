
namespace FIFAAutoBuyer_Client.Forms
{
    partial class LicenseDetailForm
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseDetailForm));
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            this.trans_accountList = new Guna.UI2.WinForms.Guna2Transition(); 
            this.txt_validUpto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_createdAt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_licenseKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_LicenseHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_licenseKey = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_createdAt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_validUpto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.trans_editUserForm = new Guna.UI2.WinForms.Guna2Transition();
            this.SuspendLayout();
            // 
            // trans_accountList
            // 
            this.trans_accountList.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.trans_accountList.Cursor = null;
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
            animation3.TransparencyCoeff = 0F;
            this.trans_accountList.DefaultAnimation = animation3;
            this.trans_accountList.TimeStep = 1F; 
            // 
            // txt_validUpto
            // 
            this.txt_validUpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_validUpto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_editUserForm.SetDecoration(this.txt_validUpto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.txt_validUpto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_validUpto.DefaultText = "";
            this.txt_validUpto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_validUpto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_validUpto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_validUpto.DisabledState.Parent = this.txt_validUpto;
            this.txt_validUpto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_validUpto.Enabled = false;
            this.txt_validUpto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_validUpto.FocusedState.Parent = this.txt_validUpto;
            this.txt_validUpto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_validUpto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_validUpto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_validUpto.HoverState.Parent = this.txt_validUpto;
            this.txt_validUpto.Location = new System.Drawing.Point(348, 172);
            this.txt_validUpto.Name = "txt_validUpto";
            this.txt_validUpto.PasswordChar = '\0';
            this.txt_validUpto.PlaceholderText = "Valid Upto";
            this.txt_validUpto.SelectedText = "";
            this.txt_validUpto.ShadowDecoration.Parent = this.txt_validUpto;
            this.txt_validUpto.Size = new System.Drawing.Size(281, 36);
            this.txt_validUpto.TabIndex = 16;
            // 
            // txt_createdAt
            // 
            this.txt_createdAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_createdAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_editUserForm.SetDecoration(this.txt_createdAt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.txt_createdAt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_createdAt.DefaultText = "";
            this.txt_createdAt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_createdAt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_createdAt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_createdAt.DisabledState.Parent = this.txt_createdAt;
            this.txt_createdAt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_createdAt.Enabled = false;
            this.txt_createdAt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_createdAt.FocusedState.Parent = this.txt_createdAt;
            this.txt_createdAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_createdAt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_createdAt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_createdAt.HoverState.Parent = this.txt_createdAt;
            this.txt_createdAt.Location = new System.Drawing.Point(348, 130);
            this.txt_createdAt.Name = "txt_createdAt";
            this.txt_createdAt.PasswordChar = '\0';
            this.txt_createdAt.PlaceholderText = "Created At";
            this.txt_createdAt.SelectedText = "";
            this.txt_createdAt.ShadowDecoration.Parent = this.txt_createdAt;
            this.txt_createdAt.Size = new System.Drawing.Size(281, 36);
            this.txt_createdAt.TabIndex = 15;
            // 
            // txt_licenseKey
            // 
            this.txt_licenseKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_licenseKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans_editUserForm.SetDecoration(this.txt_licenseKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.txt_licenseKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_licenseKey.DefaultText = "";
            this.txt_licenseKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_licenseKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_licenseKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_licenseKey.DisabledState.Parent = this.txt_licenseKey;
            this.txt_licenseKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_licenseKey.Enabled = false;
            this.txt_licenseKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_licenseKey.FocusedState.Parent = this.txt_licenseKey;
            this.txt_licenseKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_licenseKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_licenseKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_licenseKey.HoverState.Parent = this.txt_licenseKey;
            this.txt_licenseKey.Location = new System.Drawing.Point(348, 88);
            this.txt_licenseKey.Name = "txt_licenseKey";
            this.txt_licenseKey.PasswordChar = '\0';
            this.txt_licenseKey.PlaceholderText = "License Key";
            this.txt_licenseKey.SelectedText = "";
            this.txt_licenseKey.ShadowDecoration.Parent = this.txt_licenseKey;
            this.txt_licenseKey.Size = new System.Drawing.Size(281, 36);
            this.txt_licenseKey.TabIndex = 14;
            this.txt_licenseKey.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lbl_LicenseHeader
            // 
            this.lbl_LicenseHeader.BackColor = System.Drawing.Color.Transparent;
            this.trans_editUserForm.SetDecoration(this.lbl_LicenseHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.lbl_LicenseHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_LicenseHeader.Location = new System.Drawing.Point(418, 36);
            this.lbl_LicenseHeader.Name = "lbl_LicenseHeader";
            this.lbl_LicenseHeader.Size = new System.Drawing.Size(70, 15);
            this.lbl_LicenseHeader.TabIndex = 17;
            this.lbl_LicenseHeader.Text = "License Detail";
            // 
            // lbl_licenseKey
            // 
            this.lbl_licenseKey.BackColor = System.Drawing.Color.Transparent;
            this.trans_editUserForm.SetDecoration(this.lbl_licenseKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.lbl_licenseKey, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_licenseKey.Location = new System.Drawing.Point(250, 99);
            this.lbl_licenseKey.Name = "lbl_licenseKey";
            this.lbl_licenseKey.Size = new System.Drawing.Size(61, 15);
            this.lbl_licenseKey.TabIndex = 18;
            this.lbl_licenseKey.Text = "License Key";
            // 
            // lbl_createdAt
            // 
            this.lbl_createdAt.BackColor = System.Drawing.Color.Transparent;
            this.trans_editUserForm.SetDecoration(this.lbl_createdAt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.lbl_createdAt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_createdAt.Location = new System.Drawing.Point(250, 142);
            this.lbl_createdAt.Name = "lbl_createdAt";
            this.lbl_createdAt.Size = new System.Drawing.Size(53, 15);
            this.lbl_createdAt.TabIndex = 19;
            this.lbl_createdAt.Text = "Created At";
            // 
            // lbl_validUpto
            // 
            this.lbl_validUpto.BackColor = System.Drawing.Color.Transparent;
            this.trans_editUserForm.SetDecoration(this.lbl_validUpto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this.lbl_validUpto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_validUpto.Location = new System.Drawing.Point(250, 182);
            this.lbl_validUpto.Name = "lbl_validUpto";
            this.lbl_validUpto.Size = new System.Drawing.Size(52, 15);
            this.lbl_validUpto.TabIndex = 20;
            this.lbl_validUpto.Text = "Valid Upto";
            // 
            // trans_editUserForm
            // 
            this.trans_editUserForm.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.trans_editUserForm.Cursor = null;
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
            animation4.TransparencyCoeff = 1F;
            this.trans_editUserForm.DefaultAnimation = animation4;
            this.trans_editUserForm.Interval = 50;
            this.trans_editUserForm.TimeStep = 1F;
            // 
            // LicenseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1011, 701);
            this.Controls.Add(this.lbl_validUpto);
            this.Controls.Add(this.lbl_createdAt);
            this.Controls.Add(this.lbl_licenseKey);
            this.Controls.Add(this.lbl_LicenseHeader);
            this.Controls.Add(this.txt_validUpto);
            this.Controls.Add(this.txt_createdAt);
            this.Controls.Add(this.txt_licenseKey);
            this.trans_editUserForm.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.trans_accountList.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicenseDetailForm";
            this.Text = "List";
            this.Load += new System.EventHandler(this.LicenseDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition trans_accountList;
        private Guna.UI2.WinForms.Guna2Transition trans_editUserForm; 
        private Guna.UI2.WinForms.Guna2TextBox txt_validUpto;
        private Guna.UI2.WinForms.Guna2TextBox txt_createdAt;
        private Guna.UI2.WinForms.Guna2TextBox txt_licenseKey;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_LicenseHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_licenseKey;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_createdAt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_validUpto;
    }
}