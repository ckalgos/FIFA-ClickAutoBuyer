namespace FIFAAutoBuyer_Client.Forms
{
    partial class OtpForm
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
            this.components = new System.ComponentModel.Container();
            this.lbl_enterOtp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_editCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_submitOtp = new Guna.UI2.WinForms.Guna2Button();
            this.txt_userOtp = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_EditForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_EditForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_enterOtp
            // 
            this.lbl_enterOtp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enterOtp.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterOtp.Location = new System.Drawing.Point(148, 17);
            this.lbl_enterOtp.Name = "lbl_enterOtp";
            this.lbl_enterOtp.Size = new System.Drawing.Size(67, 23);
            this.lbl_enterOtp.TabIndex = 13;
            this.lbl_enterOtp.Text = "Enter Otp";
            // 
            // btn_editCancel
            // 
            this.btn_editCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.BorderRadius = 3;
            this.btn_editCancel.BorderThickness = 1;
            this.btn_editCancel.CheckedState.Parent = this.btn_editCancel;
            this.btn_editCancel.CustomImages.Parent = this.btn_editCancel;
            this.btn_editCancel.FillColor = System.Drawing.Color.Transparent;
            this.btn_editCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editCancel.ForeColor = System.Drawing.Color.Navy;
            this.btn_editCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_editCancel.HoverState.Parent = this.btn_editCancel;
            this.btn_editCancel.Location = new System.Drawing.Point(88, 129);
            this.btn_editCancel.Name = "btn_editCancel";
            this.btn_editCancel.ShadowDecoration.Parent = this.btn_editCancel;
            this.btn_editCancel.Size = new System.Drawing.Size(84, 30);
            this.btn_editCancel.TabIndex = 12;
            this.btn_editCancel.Text = "Cancel";
            this.btn_editCancel.Click += new System.EventHandler(this.btn_editCancel_Click);
            // 
            // btn_submitOtp
            // 
            this.btn_submitOtp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_submitOtp.BorderRadius = 3;
            this.btn_submitOtp.BorderThickness = 1;
            this.btn_submitOtp.CheckedState.Parent = this.btn_submitOtp;
            this.btn_submitOtp.CustomImages.Parent = this.btn_submitOtp;
            this.btn_submitOtp.FillColor = System.Drawing.Color.Transparent;
            this.btn_submitOtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_submitOtp.ForeColor = System.Drawing.Color.Navy;
            this.btn_submitOtp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_submitOtp.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_submitOtp.HoverState.Parent = this.btn_submitOtp;
            this.btn_submitOtp.Location = new System.Drawing.Point(222, 129);
            this.btn_submitOtp.Name = "btn_submitOtp";
            this.btn_submitOtp.ShadowDecoration.Parent = this.btn_submitOtp;
            this.btn_submitOtp.Size = new System.Drawing.Size(84, 30);
            this.btn_submitOtp.TabIndex = 10;
            this.btn_submitOtp.Text = "Submit";
            this.btn_submitOtp.Click += new System.EventHandler(this.btn_submitOtp_Click);
            // 
            // txt_userOtp
            // 
            this.txt_userOtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_userOtp.DefaultText = "";
            this.txt_userOtp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_userOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_userOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userOtp.DisabledState.Parent = this.txt_userOtp;
            this.txt_userOtp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userOtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userOtp.FocusedState.Parent = this.txt_userOtp;
            this.txt_userOtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_userOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userOtp.HoverState.Parent = this.txt_userOtp;
            this.txt_userOtp.Location = new System.Drawing.Point(48, 62);
            this.txt_userOtp.Name = "txt_userOtp";
            this.txt_userOtp.PasswordChar = '\0';
            this.txt_userOtp.PlaceholderText = "Otp";
            this.txt_userOtp.SelectedText = "";
            this.txt_userOtp.ShadowDecoration.Parent = this.txt_userOtp;
            this.txt_userOtp.Size = new System.Drawing.Size(281, 36);
            this.txt_userOtp.TabIndex = 2;
            this.txt_userOtp.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // panel_EditForm
            // 
            this.panel_EditForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_EditForm.BorderRadius = 8;
            this.panel_EditForm.BorderThickness = 1;
            this.panel_EditForm.Controls.Add(this.lbl_enterOtp);
            this.panel_EditForm.Controls.Add(this.btn_editCancel);
            this.panel_EditForm.Controls.Add(this.btn_submitOtp);
            this.panel_EditForm.Controls.Add(this.txt_userOtp);
            this.panel_EditForm.Location = new System.Drawing.Point(2, 4);
            this.panel_EditForm.Name = "panel_EditForm";
            this.panel_EditForm.ShadowDecoration.Parent = this.panel_EditForm;
            this.panel_EditForm.Size = new System.Drawing.Size(386, 184);
            this.panel_EditForm.TabIndex = 5;
            // 
            // OtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 191);
            this.Controls.Add(this.panel_EditForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Otp";
            this.panel_EditForm.ResumeLayout(false);
            this.panel_EditForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_editCancel;
        private Guna.UI2.WinForms.Guna2Button btn_submitOtp;
        private Guna.UI2.WinForms.Guna2TextBox txt_userOtp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_enterOtp;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panel_EditForm;
    }
}