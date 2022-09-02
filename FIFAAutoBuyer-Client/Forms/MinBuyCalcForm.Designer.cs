
namespace FIFAAutoBuyer_Client.Forms
{
    partial class MinBuyCalcForm
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
            this.cmb_abSearches = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_getMin = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_accounts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_minResult = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grd_minPrices = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_minPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_abSearches
            // 
            this.cmb_abSearches.BackColor = System.Drawing.Color.Transparent;
            this.cmb_abSearches.DisplayMember = "DisplayValue";
            this.cmb_abSearches.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_abSearches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_abSearches.DropDownWidth = 36;
            this.cmb_abSearches.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_abSearches.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_abSearches.FocusedState.Parent = this.cmb_abSearches;
            this.cmb_abSearches.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_abSearches.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_abSearches.HoverState.Parent = this.cmb_abSearches;
            this.cmb_abSearches.IntegralHeight = false;
            this.cmb_abSearches.ItemHeight = 30;
            this.cmb_abSearches.Items.AddRange(new object[] {
            "-- Select Search --"});
            this.cmb_abSearches.ItemsAppearance.Parent = this.cmb_abSearches;
            this.cmb_abSearches.Location = new System.Drawing.Point(391, 98);
            this.cmb_abSearches.Name = "cmb_abSearches";
            this.cmb_abSearches.ShadowDecoration.Parent = this.cmb_abSearches;
            this.cmb_abSearches.Size = new System.Drawing.Size(224, 36);
            this.cmb_abSearches.StartIndex = 0;
            this.cmb_abSearches.TabIndex = 34;
            this.cmb_abSearches.ValueMember = "Id";
            // 
            // btn_getMin
            // 
            this.btn_getMin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_getMin.BorderRadius = 3;
            this.btn_getMin.BorderThickness = 1;
            this.btn_getMin.CheckedState.Parent = this.btn_getMin;
            this.btn_getMin.CustomImages.Parent = this.btn_getMin;
            this.btn_getMin.FillColor = System.Drawing.Color.Transparent;
            this.btn_getMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_getMin.ForeColor = System.Drawing.Color.Navy;
            this.btn_getMin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_getMin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_getMin.HoverState.Parent = this.btn_getMin;
            this.btn_getMin.Location = new System.Drawing.Point(404, 175);
            this.btn_getMin.Name = "btn_getMin";
            this.btn_getMin.ShadowDecoration.Parent = this.btn_getMin;
            this.btn_getMin.Size = new System.Drawing.Size(165, 30);
            this.btn_getMin.TabIndex = 35;
            this.btn_getMin.Text = "Get Min Price";
            this.btn_getMin.Click += new System.EventHandler(this.btn_getMin_Click);
            // 
            // cmb_accounts
            // 
            this.cmb_accounts.BackColor = System.Drawing.Color.Transparent;
            this.cmb_accounts.DisplayMember = "DisplayValue";
            this.cmb_accounts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accounts.DropDownWidth = 36;
            this.cmb_accounts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_accounts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_accounts.FocusedState.Parent = this.cmb_accounts;
            this.cmb_accounts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_accounts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_accounts.HoverState.Parent = this.cmb_accounts;
            this.cmb_accounts.IntegralHeight = false;
            this.cmb_accounts.ItemHeight = 30;
            this.cmb_accounts.Items.AddRange(new object[] {
            "-- Select a account --"});
            this.cmb_accounts.ItemsAppearance.Parent = this.cmb_accounts;
            this.cmb_accounts.Location = new System.Drawing.Point(391, 32);
            this.cmb_accounts.Name = "cmb_accounts";
            this.cmb_accounts.ShadowDecoration.Parent = this.cmb_accounts;
            this.cmb_accounts.Size = new System.Drawing.Size(224, 36);
            this.cmb_accounts.StartIndex = 0;
            this.cmb_accounts.TabIndex = 37;
            this.cmb_accounts.ValueMember = "Id";
            // 
            // lbl_minResult
            // 
            this.lbl_minResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minResult.Location = new System.Drawing.Point(391, 245);
            this.lbl_minResult.Name = "lbl_minResult";
            this.lbl_minResult.Size = new System.Drawing.Size(215, 23);
            this.lbl_minResult.TabIndex = 38;
            this.lbl_minResult.Text = "Please wait searching for min price....";
            this.lbl_minResult.Visible = false;
            // 
            // grd_minPrices
            // 
            this.grd_minPrices.AllowUserToAddRows = false;
            this.grd_minPrices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grd_minPrices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_minPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_minPrices.BackgroundColor = System.Drawing.Color.White;
            this.grd_minPrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_minPrices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_minPrices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_minPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_minPrices.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_minPrices.DefaultCellStyle = dataGridViewCellStyle3;
            this.grd_minPrices.EnableHeadersVisualStyles = false;
            this.grd_minPrices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_minPrices.Location = new System.Drawing.Point(203, 290);
            this.grd_minPrices.MultiSelect = false;
            this.grd_minPrices.Name = "grd_minPrices";
            this.grd_minPrices.ReadOnly = true;
            this.grd_minPrices.RowHeadersVisible = false;
            this.grd_minPrices.RowTemplate.DividerHeight = 5;
            this.grd_minPrices.RowTemplate.Height = 50;
            this.grd_minPrices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_minPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_minPrices.Size = new System.Drawing.Size(627, 399);
            this.grd_minPrices.TabIndex = 39;
            this.grd_minPrices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grd_minPrices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_minPrices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grd_minPrices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grd_minPrices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grd_minPrices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grd_minPrices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grd_minPrices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_minPrices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.grd_minPrices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grd_minPrices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_minPrices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.grd_minPrices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grd_minPrices.ThemeStyle.HeaderStyle.Height = 40;
            this.grd_minPrices.ThemeStyle.ReadOnly = true;
            this.grd_minPrices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grd_minPrices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd_minPrices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grd_minPrices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grd_minPrices.ThemeStyle.RowsStyle.Height = 50;
            this.grd_minPrices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grd_minPrices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grd_minPrices.Visible = false;
            // 
            // MinBuyCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 701);
            this.Controls.Add(this.grd_minPrices);
            this.Controls.Add(this.lbl_minResult);
            this.Controls.Add(this.cmb_accounts);
            this.Controls.Add(this.btn_getMin);
            this.Controls.Add(this.cmb_abSearches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MinBuyCalcForm";
            this.Text = "LogViewer";
            ((System.ComponentModel.ISupportInitialize)(this.grd_minPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
         
        private Guna.UI2.WinForms.Guna2ComboBox cmb_abSearches;
        private Guna.UI2.WinForms.Guna2Button btn_getMin;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_accounts;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_minResult;
        private Guna.UI2.WinForms.Guna2DataGridView grd_minPrices;
    }
}