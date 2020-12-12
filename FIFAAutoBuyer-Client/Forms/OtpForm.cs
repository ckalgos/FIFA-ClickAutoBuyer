using System;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class OtpForm : Form
    {
        readonly Action<string, EventArgs> _onSubmit;

        public OtpForm(Action<string,EventArgs> onSubmit)
        {
            InitializeComponent();

            _onSubmit = onSubmit;
        } 

        private void btn_submitOtp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userOtp.Text))
            {
                MessageBox.Show("Please enter the Otp...");
                return;
            }
            this.Close();
            _onSubmit(txt_userOtp.Text, e);
        }

        private void btn_editCancel_Click(object sender, EventArgs e)
        {
            txt_userOtp.Text = "";
            this.Close();
            _onSubmit(txt_userOtp.Text, e);
        }
    }
}
