using System;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class PopUpBox : Form
    {
        public PopUpBox(string message)
        {
            InitializeComponent();
            this.lbl_message.Text = message ?? "Something went wrong";
        } 

        private void btn_submitOtp_Click(object sender, EventArgs e)
        { 
            this.Close(); 
        } 
    }
}
