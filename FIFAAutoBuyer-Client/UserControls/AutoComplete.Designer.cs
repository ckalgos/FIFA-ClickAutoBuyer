using MetroFramework.Controls; 
using System.Collections.Generic;
using System.ComponentModel;

namespace FIFAAutoBuyer_Client.UserControls
{
    partial class AutoComplete
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<string> _list = new List<string>();
        private string promptText = "Search Term";

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

        public override string Text
        { get => this.txt_srchTerm.Text; set => this.txt_srchTerm.Text = value; }

        [Description("DataSource"), Category("Data")]
        public List<string> DataSource
        {
            get => _list;
            set => _list = value;
        }


        [Description("PromptText"), Category("Data")]
        public string PromptText
        {
            get => promptText;
            set  { promptText = value; this.txt_srchTerm.PlaceholderText = value; }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.suggestions_listBox = new System.Windows.Forms.ListBox();
            this.txt_srchTerm = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // suggestions_listBox
            // 
            this.suggestions_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestions_listBox.FormattingEnabled = true;
            this.suggestions_listBox.ItemHeight = 24;
            this.suggestions_listBox.Location = new System.Drawing.Point(3, 51);
            this.suggestions_listBox.Name = "suggestions_listBox";
            this.suggestions_listBox.Size = new System.Drawing.Size(340, 196);
            this.suggestions_listBox.TabIndex = 5;
            this.suggestions_listBox.Visible = false;
            this.suggestions_listBox.SelectedIndexChanged += new System.EventHandler(this.suggestions_listBox_SelectedIndexChanged);
            // 
            // txt_srchTerm
            // 
            this.txt_srchTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_srchTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txt_srchTerm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_srchTerm.DefaultText = "";
            this.txt_srchTerm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_srchTerm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_srchTerm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchTerm.DisabledState.Parent = this.txt_srchTerm;
            this.txt_srchTerm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_srchTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchTerm.FocusedState.Parent = this.txt_srchTerm;
            this.txt_srchTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_srchTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_srchTerm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_srchTerm.HoverState.Parent = this.txt_srchTerm;
            this.txt_srchTerm.Location = new System.Drawing.Point(3, 15);
            this.txt_srchTerm.Name = "txt_srchTerm";
            this.txt_srchTerm.PasswordChar = '\0';
            this.txt_srchTerm.PlaceholderText = "Search Term";
            this.txt_srchTerm.SelectedText = "";
            this.txt_srchTerm.ShadowDecoration.Parent = this.txt_srchTerm;
            this.txt_srchTerm.Size = new System.Drawing.Size(340, 36);
            this.txt_srchTerm.TabIndex = 10;
            this.txt_srchTerm.TextOffset = new System.Drawing.Point(5, 0);
            this.txt_srchTerm.TextChanged += new System.EventHandler(this.txt_autoSuggestText_TextChanged);
            // 
            // AutoComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txt_srchTerm);
            this.Controls.Add(this.suggestions_listBox);
            this.Name = "AutoComplete";
            this.Size = new System.Drawing.Size(519, 250);
            this.UseCustomBackColor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox suggestions_listBox;
        private Guna.UI2.WinForms.Guna2TextBox txt_srchTerm;
    }
}
