using FIFAAutoBuyer_Client.Models;
using FIFAAutoBuyer_Lib.DataModels;
using FIFAAutoBuyer_Lib.Domain;
using FIFAAutoBuyer_Lib.Helpers;
using System;
using System.Collections.Generic; 
using System.Data; 
using System.Linq; 
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class MinBuyCalcForm : BaseForm
    {
        public MinBuyCalcForm()
        {
            InitializeComponent();

            var abSearches = new List<DropDownOption>
            {
              new DropDownOption{ Id = -1, DisplayValue = "-- Select Search --" }
            };
            abSearches.AddRange(SearchDAL.GetSearches<PlayerSearchCriteria>().Select(a => new DropDownOption { Id = a.PkId, DisplayValue = a.Name }));
            cmb_abSearches.DataSource = abSearches;

            var abAccounts = new List<DropDownOption>
            {
              new DropDownOption{ Id = -1, DisplayValue = "-- Select a account --" }
            };
            abAccounts.AddRange(UserDAL.GetUsers().Select(a => new DropDownOption { Id = a.Id, DisplayValue = a.Email }));
            cmb_accounts.DataSource = abAccounts;
        }

        private void btn_getMin_Click(object sender, EventArgs e)
        {
            if (cmb_abSearches.SelectedValue + "" == "-1")
            {
                MessageBox.Show("Select a search");
                return;
            }
            if (cmb_accounts.SelectedValue + "" == "-1")
            {
                MessageBox.Show("Login And select a account to run search with");
                return;
            }

            lbl_minResult.Visible = true;

            var playerSearchCriteria = SearchDAL.GetSearch<PlayerSearchCriteria>(cmb_abSearches.SelectedValue);
            var userCrendential = UserDAL.GetUser(cmb_accounts.SelectedValue);

            var loginResult = LoginAccount(userCrendential);
            if (loginResult == "Loggedin Successfully")
            {
                TransferHelper helper = new TransferHelper(userCrendential);
                var minPriceResults = helper.GetMinPrice(playerSearchCriteria);
                grd_minPrices.DataSource = minPriceResults;
                grd_minPrices.Visible = true;
                lbl_minResult.Text = $"Top {minPriceResults.Count} Min Price for the search";
            }
            else
            {
                MessageBox.Show("Error occured when trying to login");
            }
        }

        private string LoginAccount(UserCredential userCredential)
        {
            LoginHelper loginHelper = new LoginHelper(userCredential);
            var loginResult = loginHelper.Login();

            if (loginResult == "Please Enter the Otp")
            {
                OtpForm form = new OtpForm(onOtpSubmit);
                form.ShowDialog();
            }

            void onOtpSubmit(string otp, EventArgs e)
            {
                loginResult = loginHelper.EnterOtp(otp);
            }

            return loginResult;
        }
    }
}
