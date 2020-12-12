using FIFAAutoBuyer_Client.Forms;
using FIFAAutoBuyer_Client.Helpers;
using FIFAAutoBuyer_Lib.Models.Exceptions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_accounts_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_selectedTab.Text = "Accounts";
                FormWrapper(new AccountList(LongOperationCallBack)); 
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        public void FormChangeEvent(string type)
        {
            switch (type)
            {
                case "account":
                    btn_accounts_Click(null, null);
                    break;
                case "search":
                    lbl_selectedTab.Text = "Search Criterias";
                    FormWrapper(new SearchList(), true);
                    break;
                case "setting":
                    lbl_selectedTab.Text = "Auto Buyer Settings";
                    FormWrapper(new SettingList(), true);
                    break;
                case null:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }

        private void FormWrapper(BaseForm form, bool isOpen = false)
        {
            if (guna2Panel_container.Controls.Count > 0)
                this.guna2Panel_container.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(form);
            guna2Panel_container.Tag = form;
            form.Show(isOpen);
        }

        private void LongOperationCallBack(bool isEnabled)
        {
           CrossThreadHelper.SetEnable(this, panel_side, isEnabled);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormWrapper(new AccountList(LongOperationCallBack)); 
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        private void btn_searches_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_selectedTab.Text = "Search Criterias";
                FormWrapper(new SearchList()); 
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        private void btn_abSettings_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_selectedTab.Text = "Auto Buyer Settings";
                FormWrapper(new SettingList()); 
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        private void btn_getLicense_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_selectedTab.Text = "License Detail";
                FormWrapper(new LicenseDetailForm()); 
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog(); 
            }
        }

        private void btn_minBuyCalc_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_selectedTab.Text = "Min Buy Finder";
                FormWrapper(new MinBuyCalcForm()); 
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        private void btn_logViewer_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_selectedTab.Text = "Log Viewer";
                FormWrapper(new LogViewerForm());
            }
            catch (LicenseExpiredException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        private void appLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC5eLkjmLU2TcE4oiJM9PsyA?sub_confirmation=1");
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }

    public class BaseForm : Form
    {
        public virtual void Show(bool isOpen)
        {
            base.Show();
        }
    }
}
