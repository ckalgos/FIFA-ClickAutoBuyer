using FIFAAutoBuyer_Lib.Domain;
using LicenseValidator;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class LicenseDetailForm : BaseForm
    {
        public LicenseDetailForm()
        {
            InitializeComponent();            
        }

        private void LicenseDetail_Load(object sender, System.EventArgs e)
        {
            LicenseDetail licenseDetail =  LicenseDAL.GetLicenseDetail();

            if (licenseDetail == null)
            {
                MessageBox.Show("No Valid Lincense found");
                this.Close();
                return;
            }

            txt_createdAt.Text = licenseDetail.CreateDateTime.ToString();
            txt_licenseKey.Text = licenseDetail.UID;
            txt_validUpto.Text = licenseDetail.ValidUpto.ToString();
        }
    }
}
