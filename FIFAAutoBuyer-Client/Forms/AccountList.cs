using FIFAAutoBuyer_Client.Helpers;
using FIFAAutoBuyer_Client.Models;
using FIFAAutoBuyer_Lib.DataModels;
using FIFAAutoBuyer_Lib.Domain;
using FIFAAutoBuyer_Lib.Helpers;
using FIFAAutoBuyer_Lib.Models.Exceptions;
using Guna.UI2.WinForms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class AccountList : BaseForm
    {
        static Dictionary<object, string> _userState = new Dictionary<object, string>();
        Action<bool> _longOperationCB;

        public AccountList(Action<bool> longOperationCB)
        {
            InitializeComponent();
            HideEditForm();
            List<DropDownCheckOption> options = new List<DropDownCheckOption>();
            options.AddRange(SearchDAL.GetSearches<PlayerSearchCriteria>().Select(a => new DropDownCheckOption { Id = a.PkId, DisplayValue = a.Name }));
            this.cmb_searches.Items.AddRange(options.ToArray());
            _longOperationCB = longOperationCB;
        }

        private bool Valid()
        {
            return !string.IsNullOrEmpty(txt_userPassword.Text) || !string.IsNullOrEmpty(txt_userEmail.Text);
        }

        private void btn_editSave_Click(object sender, EventArgs e)
        {
            if (!Valid())
            {
                MessageBox.Show("Email or password is missing");
                return;
            }

            UserCredential userCredential = new UserCredential
            {
                Email = txt_userEmail.Text,
                UserPassword = txt_userPassword.Text,
                UserGAuthKey = txt_userGAuthKey.Text,
                HideBrowser = chk_hideBrowser.Checked
            };

            List<int> selectedSearches = new List<int>();

            foreach (var selectedSearch in cmb_searches.CheckBoxItems.Where(a => a.Checked))
            {
                int id;
                if (int.TryParse(selectedSearch.Tag + "", out id))
                {
                    selectedSearches.Add(id);
                }
            }

            try
            {
                if (grd_accountList.SelectedRows.Count > 0)
                {
                    object pkId = grd_accountList.SelectedRows[0].Cells["PkId"].Value;
                    userCredential.Id = Convert.ToInt32(pkId);
                    UserDAL.UpdateUser(userCredential, selectedSearches);

                    if (_userState.ContainsKey(pkId) && _userState[pkId].Contains("Loggedin"))
                    {
                        LogOutAccount(userCredential);
                    }
                }
                else
                {
                    UserDAL.SaveUser(userCredential, selectedSearches);
                }
            }
            catch (InvalidAccountCountException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }

            AccountList_Load(sender, e);

            HideEditForm();
        }

        private void ShowEditForm()
        {
            grd_accountList.Height = 328;
            trans_accountList.Show(panel_EditForm);
        }

        private void HideEditForm()
        {
            trans_editUserForm.HideSync(panel_EditForm);
            grd_accountList.Height = 607;
        }

        private void btn_editCancel_Click(object sender, EventArgs e)
        {
            HideEditForm();
            ClearFields();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            ClearFields();
            grd_accountList.ClearSelection();
            ShowEditForm();
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if (grd_accountList.SelectedRows.Count > 0)
            {
                object pkId = grd_accountList.SelectedRows[0].Cells["PkId"].Value;
                _userState.Remove(pkId);

                UserDAL.DeleteUser(pkId);

                ClearFields();

                AccountList_Load(sender, e);
            }

            HideEditForm();
        }

        private void ClearFields()
        {
            txt_userEmail.Text = string.Empty;
            txt_userPassword.Text = string.Empty;
            txt_userGAuthKey.Text = string.Empty;
        }

        private void AccountList_Load(object sender, EventArgs e)
        {
            try
            {
                List<UserCredential> usersList = UserDAL.GetUsers();
                List<Account> accounts = usersList.Select(a => new Account { PkId = a.Id, Email = a.Email, Status = GetUserStatus(a.Id) }).ToList();
                grd_accountList.DataSource = accounts.ToDataTable();

                if (accounts.Any())
                {
                    lbl_noAccounts.Visible = false;
                    grd_accountList.Visible = true;
                }
                else
                {
                    lbl_noAccounts.Visible = true;
                    grd_accountList.Visible = false;
                }
            }
            catch (InvalidAccountCountException ex)
            {
                new PopUpBox(ex.Message).ShowDialog();
            }
        }

        private void grd_accountList_SelectionChanged(object sender, EventArgs e)
        {
            HideEditForm();

            if (grd_accountList.SelectedRows.Count > 0)
            {
                object pkId = grd_accountList.SelectedRows[0].Cells["PkId"].Value;

                ToggleStartStopBtn(pkId);
            }
            else
            {
                btn_editUser.Visible = false;
                btn_deleteUser.Visible = false;
                btn_startAccount.Visible = false;
            }
        }

        private void ToggleStartStopBtn(object pkId)
        {
            if (_userState.ContainsKey(pkId) && _userState[pkId].Contains("Loggedin"))
            {
                CrossThreadHelper.SetVisiblity(this, btn_editUser, false);
                CrossThreadHelper.SetVisiblity(this, btn_deleteUser, false);
                CrossThreadHelper.SetText(this, btn_startAccount, "Stop Account");
            }
            else
            {
                CrossThreadHelper.SetVisiblity(this, btn_editUser, true);
                CrossThreadHelper.SetVisiblity(this, btn_deleteUser, true);
                CrossThreadHelper.SetText(this, btn_startAccount, "Start Account");
            }
            CrossThreadHelper.SetVisiblity(this, btn_startAccount, true);
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            if (grd_accountList.SelectedRows.Count > 0)
            {
                object pkId = grd_accountList.SelectedRows[0].Cells["PkId"].Value;
                UserCredential userCredential = UserDAL.GetUser(pkId);

                txt_userEmail.Text = userCredential.Email;
                txt_userPassword.Text = userCredential.UserPassword;
                txt_userGAuthKey.Text = userCredential.UserGAuthKey;
                chk_hideBrowser.Checked = userCredential.HideBrowser;

                foreach (var playerSearch in userCredential.PlayerSearchCriterias)
                {
                    var checkBox = cmb_searches.CheckBoxItems.FirstOrDefault(a =>
                     {
                         int id;

                         if (int.TryParse(a.Tag + "", out id))
                         {
                             return id == playerSearch.PkId;
                         }

                         return false;

                     });

                    if (checkBox != null)
                    {
                        checkBox.Checked = true;
                    }
                }
            }

            ShowEditForm();
        }

        private void grd_accountList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grd_accountList.ClearSelection();
        }

        private void btn_startAccount_Click(object sender, EventArgs e)
        {
            if (grd_accountList.SelectedRows.Count > 0)
            {
                var selectedRow = grd_accountList.SelectedRows[0];

                Guna2Button baseBtn = sender as Guna2Button;


                Task.Run(() =>
                {
                    ToggleLoader(true);
                    if (baseBtn.Text == "Start Account")
                    {
                        UserCredential userCredential;
                        var loginResult = LoginUser(selectedRow , out userCredential);

                        ToggleLoader(false);

                        if (loginResult == "Loggedin Successfully")
                        {
                            RunUserSearches(userCredential);
                        }
                    }
                    else
                    {
                        object pkId = selectedRow.Cells["PkId"].Value;
                        selectedRow.Cells["Status"].Value = SetUserStatus(pkId, "Please wait trying to logout....");

                        UserCredential userCredential = UserDAL.GetUser(pkId);

                        selectedRow.Cells["Status"].Value = SetUserStatus(pkId, LogOutAccount(userCredential));
                        ToggleLoader(false);
                    } 
                });
            }
        }

        private void ToggleLoader(bool isLoading)
        {
            CrossThreadHelper.SetLoader(this, progress_loader, isLoading);
            _longOperationCB(!isLoading);
            CrossThreadHelper.SetEnable(this, grd_accountList, !isLoading);
        }

        private string LoginUser(DataGridViewRow selectedRow, out UserCredential userCredential)
        {
            object pkId = selectedRow.Cells["PkId"].Value;

            selectedRow.Cells["Status"].Value = SetUserStatus(pkId, "Please wait trying to login....");

            userCredential = UserDAL.GetUser(pkId);

            var loginResult = LoginAccount(userCredential);

            if (loginResult == "Loggedin Successfully" && !userCredential.PlayerSearchCriterias.Any())
            {
                loginResult += " but no searches associated";
            }

            selectedRow.Cells["Status"].Value = SetUserStatus(pkId, loginResult);

            return loginResult;
        }

        private void RunUserSearches(UserCredential userCredential)
        {
            TransferHelper helper = new TransferHelper(userCredential);
            while (GetUserStatus(userCredential.Id) == "Loggedin Successfully")
            {
                try
                {
                    foreach (var search in userCredential.PlayerSearchCriterias)
                    {
                        if (search.ABSetting == null && search.SettingId != null)
                        {
                            search.ABSetting = SettingDAL.GetSetting(search.SettingId);
                        }
                        if (!string.IsNullOrEmpty(search.ABSetting.BuyPrice))
                        {
                            helper.SnipeCard(search);
                        }

                        if (search.ABSetting.SellTransferList)
                        {
                            helper.SellCards();
                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
        }

        private string LoginAccount(UserCredential userCredential)
        {
            try
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
            catch (WebDriverException ex)
            {
                if (ex.Message.Contains("user data directory is already in use"))
                {
                    new PopUpBox("Already active session exist for this user, close existing browser and try starting again").ShowDialog();
                }
                else
                {
                    new PopUpBox(ex.Message).ShowDialog();
                }
            }
            return "Not Logged In";
        }

        private string LogOutAccount(UserCredential userCredential)
        {
            LoginHelper loginHelper = new LoginHelper(userCredential);
            var logOutResult = loginHelper.LogOut();

            if (logOutResult)
            {
                return "Not Logged In";
            }

            return "Unable to Log out";
        }

        private void lnk_newSearch_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Parent.Parent as MainForm;
            mainForm.FormChangeEvent("search");
        }

        private string GetUserStatus(object pkID)
        {
            if (!_userState.ContainsKey(pkID))
            {
                _userState[pkID] = "Not Logged In";
            }
            return _userState[pkID];
        }

        private string SetUserStatus(object pkID, string userStatus)
        {
            _userState[pkID] = userStatus;

            ToggleStartStopBtn(pkID);

            return userStatus;
        }
    }
}
