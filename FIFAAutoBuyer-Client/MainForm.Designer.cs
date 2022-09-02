
namespace FIFAAutoBuyer_Client
{
    partial class MainForm
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_selectedTab = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.btn_accounts = new Guna.UI2.WinForms.Guna2Button();
            this.btn_getLicense = new Guna.UI2.WinForms.Guna2Button();
            this.appLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_side = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logViewer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_minBuyCalc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_abSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_searches = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel_container = new Guna.UI2.WinForms.Guna2Panel();
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.panel_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BorderColor = System.Drawing.Color.Silver;
            this.panel_top.Controls.Add(this.btn_minimize);
            this.panel_top.Controls.Add(this.lbl_selectedTab);
            this.panel_top.Controls.Add(this.btn_maximize);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.CustomBorderColor = System.Drawing.Color.Silver;
            this.panel_top.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Transition1.SetDecoration(this.panel_top, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(197, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.ShadowDecoration.Parent = this.panel_top;
            this.panel_top.Size = new System.Drawing.Size(1011, 53);
            this.panel_top.TabIndex = 1;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BorderColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BorderThickness = 1;
            this.btn_minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.btn_minimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_minimize.FillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_minimize.HoverState.IconColor = System.Drawing.Color.Blue;
            this.btn_minimize.HoverState.Parent = this.btn_minimize;
            this.btn_minimize.IconColor = System.Drawing.Color.Gray;
            this.btn_minimize.Location = new System.Drawing.Point(857, 8);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Parent = this.btn_minimize;
            this.btn_minimize.Size = new System.Drawing.Size(45, 29);
            this.btn_minimize.TabIndex = 13;
            // 
            // lbl_selectedTab
            // 
            this.lbl_selectedTab.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbl_selectedTab, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbl_selectedTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedTab.Location = new System.Drawing.Point(64, 14);
            this.lbl_selectedTab.Name = "lbl_selectedTab";
            this.lbl_selectedTab.Size = new System.Drawing.Size(65, 23);
            this.lbl_selectedTab.TabIndex = 2;
            this.lbl_selectedTab.Text = "Accounts";
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BorderColor = System.Drawing.Color.Transparent;
            this.btn_maximize.BorderThickness = 1;
            this.btn_maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2Transition1.SetDecoration(this.btn_maximize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_maximize.Enabled = false;
            this.btn_maximize.FillColor = System.Drawing.Color.Transparent;
            this.btn_maximize.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_maximize.HoverState.IconColor = System.Drawing.Color.Blue;
            this.btn_maximize.HoverState.Parent = this.btn_maximize;
            this.btn_maximize.IconColor = System.Drawing.Color.Gray;
            this.btn_maximize.Location = new System.Drawing.Point(908, 8);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.ShadowDecoration.Parent = this.btn_maximize;
            this.btn_maximize.Size = new System.Drawing.Size(45, 29);
            this.btn_maximize.TabIndex = 12;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BorderColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderThickness = 1;
            this.guna2Transition1.SetDecoration(this.btn_close, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_close.HoverState.IconColor = System.Drawing.Color.Blue;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.IconColor = System.Drawing.Color.Gray;
            this.btn_close.Location = new System.Drawing.Point(959, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(45, 29);
            this.btn_close.TabIndex = 11;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.guna2Transition1.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.Interval = 20;
            // 
            // btn_accounts
            // 
            this.btn_accounts.CheckedState.Parent = this.btn_accounts;
            this.btn_accounts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_accounts.CustomImages.Parent = this.btn_accounts;
            this.guna2Transition1.SetDecoration(this.btn_accounts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_accounts.FillColor = System.Drawing.Color.Transparent;
            this.btn_accounts.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accounts.ForeColor = System.Drawing.Color.Black;
            this.btn_accounts.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_accounts.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_accounts.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_accounts.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_accounts.HoverState.Image")));
            this.btn_accounts.HoverState.Parent = this.btn_accounts;
            this.btn_accounts.Image = ((System.Drawing.Image)(resources.GetObject("btn_accounts.Image")));
            this.btn_accounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_accounts.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_accounts.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_accounts.Location = new System.Drawing.Point(0, 91);
            this.btn_accounts.Name = "btn_accounts";
            this.btn_accounts.ShadowDecoration.Parent = this.btn_accounts;
            this.btn_accounts.Size = new System.Drawing.Size(197, 36);
            this.btn_accounts.TabIndex = 2;
            this.btn_accounts.Text = "Accounts";
            this.btn_accounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_accounts.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_accounts.Click += new System.EventHandler(this.btn_accounts_Click);
            // 
            // btn_getLicense
            // 
            this.btn_getLicense.CheckedState.Parent = this.btn_getLicense;
            this.btn_getLicense.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_getLicense.CustomImages.Parent = this.btn_getLicense;
            this.guna2Transition1.SetDecoration(this.btn_getLicense, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_getLicense.FillColor = System.Drawing.Color.Transparent;
            this.btn_getLicense.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getLicense.ForeColor = System.Drawing.Color.Black;
            this.btn_getLicense.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_getLicense.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_getLicense.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_getLicense.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_getLicense.HoverState.Image")));
            this.btn_getLicense.HoverState.Parent = this.btn_getLicense;
            this.btn_getLicense.Image = ((System.Drawing.Image)(resources.GetObject("btn_getLicense.Image")));
            this.btn_getLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_getLicense.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_getLicense.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_getLicense.Location = new System.Drawing.Point(0, 689);
            this.btn_getLicense.Name = "btn_getLicense";
            this.btn_getLicense.ShadowDecoration.Parent = this.btn_getLicense;
            this.btn_getLicense.Size = new System.Drawing.Size(197, 36);
            this.btn_getLicense.TabIndex = 5;
            this.btn_getLicense.Text = "License Detail";
            this.btn_getLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_getLicense.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_getLicense.Click += new System.EventHandler(this.btn_getLicense_Click);
            // 
            // appLogo
            // 
            this.appLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.guna2Transition1.SetDecoration(this.appLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(49, 14);
            this.appLogo.Name = "appLogo";
            this.appLogo.ShadowDecoration.Parent = this.appLogo;
            this.appLogo.Size = new System.Drawing.Size(82, 50);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 6;
            this.appLogo.TabStop = false;
            this.appLogo.Click += new System.EventHandler(this.appLogo_Click);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panel_side.Controls.Add(this.btn_logViewer);
            this.panel_side.Controls.Add(this.btn_minBuyCalc);
            this.panel_side.Controls.Add(this.btn_abSettings);
            this.panel_side.Controls.Add(this.appLogo);
            this.panel_side.Controls.Add(this.btn_searches);
            this.panel_side.Controls.Add(this.btn_getLicense);
            this.panel_side.Controls.Add(this.btn_accounts);
            this.guna2Transition1.SetDecoration(this.panel_side, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panel_side.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.ShadowDecoration.Parent = this.panel_side;
            this.panel_side.Size = new System.Drawing.Size(197, 754);
            this.panel_side.TabIndex = 0;
            // 
            // btn_logViewer
            // 
            this.btn_logViewer.CheckedState.Parent = this.btn_logViewer;
            this.btn_logViewer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_logViewer.CustomImages.Parent = this.btn_logViewer;
            this.guna2Transition1.SetDecoration(this.btn_logViewer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_logViewer.FillColor = System.Drawing.Color.Transparent;
            this.btn_logViewer.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logViewer.ForeColor = System.Drawing.Color.Black;
            this.btn_logViewer.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_logViewer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_logViewer.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_logViewer.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_logViewer.HoverState.Image")));
            this.btn_logViewer.HoverState.Parent = this.btn_logViewer;
            this.btn_logViewer.Image = ((System.Drawing.Image)(resources.GetObject("btn_logViewer.Image")));
            this.btn_logViewer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logViewer.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_logViewer.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_logViewer.Location = new System.Drawing.Point(0, 259);
            this.btn_logViewer.Name = "btn_logViewer";
            this.btn_logViewer.ShadowDecoration.Parent = this.btn_logViewer;
            this.btn_logViewer.Size = new System.Drawing.Size(197, 36);
            this.btn_logViewer.TabIndex = 12;
            this.btn_logViewer.Text = "Log Viewer";
            this.btn_logViewer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logViewer.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_logViewer.Click += new System.EventHandler(this.btn_logViewer_Click);
            // 
            // btn_minBuyCalc
            // 
            this.btn_minBuyCalc.CheckedState.Parent = this.btn_minBuyCalc;
            this.btn_minBuyCalc.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_minBuyCalc.CustomImages.Parent = this.btn_minBuyCalc;
            this.guna2Transition1.SetDecoration(this.btn_minBuyCalc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_minBuyCalc.FillColor = System.Drawing.Color.Transparent;
            this.btn_minBuyCalc.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minBuyCalc.ForeColor = System.Drawing.Color.Black;
            this.btn_minBuyCalc.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_minBuyCalc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_minBuyCalc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_minBuyCalc.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_minBuyCalc.HoverState.Image")));
            this.btn_minBuyCalc.HoverState.Parent = this.btn_minBuyCalc;
            this.btn_minBuyCalc.Image = ((System.Drawing.Image)(resources.GetObject("btn_minBuyCalc.Image")));
            this.btn_minBuyCalc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_minBuyCalc.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_minBuyCalc.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_minBuyCalc.Location = new System.Drawing.Point(0, 217);
            this.btn_minBuyCalc.Name = "btn_minBuyCalc";
            this.btn_minBuyCalc.ShadowDecoration.Parent = this.btn_minBuyCalc;
            this.btn_minBuyCalc.Size = new System.Drawing.Size(197, 36);
            this.btn_minBuyCalc.TabIndex = 11;
            this.btn_minBuyCalc.Text = "Min Buy Finder";
            this.btn_minBuyCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_minBuyCalc.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_minBuyCalc.Click += new System.EventHandler(this.btn_minBuyCalc_Click);
            // 
            // btn_abSettings
            // 
            this.btn_abSettings.CheckedState.Parent = this.btn_abSettings;
            this.btn_abSettings.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_abSettings.CustomImages.Parent = this.btn_abSettings;
            this.guna2Transition1.SetDecoration(this.btn_abSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_abSettings.FillColor = System.Drawing.Color.Transparent;
            this.btn_abSettings.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abSettings.ForeColor = System.Drawing.Color.Black;
            this.btn_abSettings.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_abSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_abSettings.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_abSettings.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_abSettings.HoverState.Image")));
            this.btn_abSettings.HoverState.Parent = this.btn_abSettings;
            this.btn_abSettings.Image = ((System.Drawing.Image)(resources.GetObject("btn_abSettings.Image")));
            this.btn_abSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_abSettings.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_abSettings.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_abSettings.Location = new System.Drawing.Point(0, 175);
            this.btn_abSettings.Name = "btn_abSettings";
            this.btn_abSettings.ShadowDecoration.Parent = this.btn_abSettings;
            this.btn_abSettings.Size = new System.Drawing.Size(197, 36);
            this.btn_abSettings.TabIndex = 10;
            this.btn_abSettings.Text = "Auto Buyer Settings";
            this.btn_abSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_abSettings.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_abSettings.Click += new System.EventHandler(this.btn_abSettings_Click);
            // 
            // btn_searches
            // 
            this.btn_searches.CheckedState.Parent = this.btn_searches;
            this.btn_searches.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btn_searches.CustomImages.Parent = this.btn_searches;
            this.guna2Transition1.SetDecoration(this.btn_searches, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_searches.FillColor = System.Drawing.Color.Transparent;
            this.btn_searches.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searches.ForeColor = System.Drawing.Color.Black;
            this.btn_searches.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.btn_searches.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(83)))), ((int)(((byte)(251)))));
            this.btn_searches.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_searches.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_searches.HoverState.Image")));
            this.btn_searches.HoverState.Parent = this.btn_searches;
            this.btn_searches.Image = ((System.Drawing.Image)(resources.GetObject("btn_searches.Image")));
            this.btn_searches.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_searches.ImageOffset = new System.Drawing.Point(5, 0);
            this.btn_searches.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_searches.Location = new System.Drawing.Point(0, 133);
            this.btn_searches.Name = "btn_searches";
            this.btn_searches.ShadowDecoration.Parent = this.btn_searches;
            this.btn_searches.Size = new System.Drawing.Size(197, 36);
            this.btn_searches.TabIndex = 9;
            this.btn_searches.Text = "Search Criterias";
            this.btn_searches.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_searches.TextOffset = new System.Drawing.Point(12, 0);
            this.btn_searches.Click += new System.EventHandler(this.btn_searches_Click);
            // 
            // guna2Panel_container
            // 
            this.guna2Transition1.SetDecoration(this.guna2Panel_container, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel_container.Location = new System.Drawing.Point(197, 53);
            this.guna2Panel_container.Name = "guna2Panel_container";
            this.guna2Panel_container.ShadowDecoration.Parent = this.guna2Panel_container;
            this.guna2Panel_container.Size = new System.Drawing.Size(1011, 701);
            this.guna2Panel_container.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1208, 754);
            this.Controls.Add(this.guna2Panel_container);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIFA AutoBuyer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.panel_side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox appLogo;
        private Guna.UI2.WinForms.Guna2Panel panel_top; 
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_selectedTab;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;  
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2Button btn_accounts;
        private Guna.UI2.WinForms.Guna2Button btn_getLicense; 
        private Guna.UI2.WinForms.Guna2Panel panel_side; 
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_container; 
        private Guna.UI2.WinForms.Guna2Button btn_searches;
        private Guna.UI2.WinForms.Guna2Button btn_abSettings;
        private Guna.UI2.WinForms.Guna2Button btn_minBuyCalc;
        private Guna.UI2.WinForms.Guna2Button btn_logViewer;
        private Guna.UI2.WinForms.Guna2ControlBox btn_minimize;
        private Guna.UI2.WinForms.Guna2ControlBox btn_maximize;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
    }
}

