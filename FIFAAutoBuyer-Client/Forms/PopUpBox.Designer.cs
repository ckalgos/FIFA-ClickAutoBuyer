namespace FIFAAutoBuyer_Client.Forms
{
    partial class PopUpBox
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
            this.lbl_message = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_submitOtp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_EditForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_EditForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_message.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(59, 50);
            this.lbl_message.MaximumSize = new System.Drawing.Size(280, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(3, 2);
            this.lbl_message.TabIndex = 13;
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
            this.btn_submitOtp.Location = new System.Drawing.Point(141, 125);
            this.btn_submitOtp.Name = "btn_submitOtp";
            this.btn_submitOtp.ShadowDecoration.Parent = this.btn_submitOtp;
            this.btn_submitOtp.Size = new System.Drawing.Size(84, 30);
            this.btn_submitOtp.TabIndex = 10;
            this.btn_submitOtp.Text = "Ok";
            this.btn_submitOtp.Click += new System.EventHandler(this.btn_submitOtp_Click);
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
            this.panel_EditForm.Controls.Add(this.lbl_message);
            this.panel_EditForm.Controls.Add(this.btn_submitOtp);
            this.panel_EditForm.Location = new System.Drawing.Point(2, 4);
            this.panel_EditForm.Name = "panel_EditForm";
            this.panel_EditForm.ShadowDecoration.Parent = this.panel_EditForm;
            this.panel_EditForm.Size = new System.Drawing.Size(386, 184);
            this.panel_EditForm.TabIndex = 5;
            // 
            // PopUpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 191);
            this.Controls.Add(this.panel_EditForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Otp";
            this.panel_EditForm.ResumeLayout(false);
            this.panel_EditForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_submitOtp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_message;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panel_EditForm;
    }
}