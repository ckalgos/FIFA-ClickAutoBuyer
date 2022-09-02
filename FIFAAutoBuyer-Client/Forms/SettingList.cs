using FIFAAutoBuyer_Client.Helpers;
using FIFAAutoBuyer_Client.Models;
using FIFAAutoBuyer_Lib.DataModels;
using FIFAAutoBuyer_Lib.Domain; 
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class SettingList : BaseForm
    { 
        public SettingList()
        {
            InitializeComponent();
            HideSettingForm(); 
        }

        private void btn_editCancel_Click(object sender, EventArgs e)
        { 
            HideSettingForm();
        }

        private void btn_editSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_settingSaveName.Text))
            {
                MessageBox.Show("Setting Name Required");
                return;
            }

            ABSetting setting = GetSettingsFromForm();

            if (grd_settingsList.SelectedRows.Count > 0)
            {
                object pkId = grd_settingsList.SelectedRows[0].Cells["PkId"].Value;
                setting.PkId = Convert.ToInt32(pkId); 
                SettingDAL.UpdateSetting(setting); 
            }
            else
            {
                SettingDAL.SaveSetting(setting);
            }

            SettingList_Load(sender, e);

            HideSettingForm();
        }

        private void btn_editSetting_Click(object sender, EventArgs e)
        {
            if (grd_settingsList.SelectedRows.Count > 0)
            {
                object pkId = grd_settingsList.SelectedRows[0].Cells["PkId"].Value;
                ABSetting setting = SettingDAL.GetSetting(pkId);

                FillFormFormSetting(setting);
            }

            ShowSettingForm();
        }

        private void btn_newSetting_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            grd_settingsList.ClearSelection();
            ShowSettingForm();
        }

        private void btn_deleteSetting_Click(object sender, EventArgs e)
        {
            if (grd_settingsList.SelectedRows.Count > 0)
            {
                object pkId = grd_settingsList.SelectedRows[0].Cells["PkId"].Value;
                SettingDAL.DeleteSetting(pkId);                 

                SettingList_Load(sender, e);
            }
            HideSettingForm();
        }

        private void ShowSettingForm()
        {
            grd_settingsList.Height = 269;
            trans_settingForm.Show(panel_SettingForm);
        }

        private void HideSettingForm()
        {
            trans_settingForm.HideSync(panel_SettingForm);
            grd_settingsList.Height = 607;
        }

        private void grd_settingList_SelectionChanged(object sender, EventArgs e)
        {
            HideSettingForm();

            if (grd_settingsList.SelectedRows.Count > 0)
            {
                btn_editSetting.Visible = true;

                DataRowView rowView = grd_settingsList.SelectedRows[0].DataBoundItem as DataRowView;
                DataRow row = rowView?.Row;
                btn_deleteSetting.Visible = (row?[row.ItemArray.Length - 1] == null);
            }
            else
            {
                btn_editSetting.Visible = false;
                btn_deleteSetting.Visible = false;
            }
        }

        public override void Show(bool isOpen)
        {
            base.Show();

            if (isOpen)
            {
                btn_newSetting_Click(null, null);
            }
        }

        private void grd_settingList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grd_settingsList.ClearSelection();
            grd_settingsList.HideColumns(AppConstants.SettingsColumnsToHide);
        }

        private void SettingList_Load(object sender, EventArgs e)
        {
            List<ABSetting> settings = SettingDAL.GetSettings();
            grd_settingsList.DataSource = settings.ToDataTable();

            if (settings.Any())
            {
                lbl_noSettings.Visible = false;
                grd_settingsList.Visible = true;
            }
            else
            {
                lbl_noSettings.Visible = true;
                grd_settingsList.Visible = false;
            }
        } 
        private ABSetting GetSettingsFromForm()
        {
            ABSetting setting = new ABSetting
            {
                Name = txt_settingSaveName.Text, 
                BuyPrice = txt_buyPrice.Text,
                ListPrice = txt_listPrice.Text,
                SellBoughtItem = chk_sellBoughtCard.Checked,
                SellTransferList = chk_sellAllCards.Checked, 
                 
            };

            return setting;
        } 

        private void FillFormFormSetting(ABSetting setting)
        {
            if (setting != null)
            {
                txt_settingSaveName.Text = setting.Name;
                txt_buyPrice.Text = setting.BuyPrice;
                txt_listPrice.Text = setting.ListPrice;
                chk_sellBoughtCard.Checked = setting.SellBoughtItem;
                chk_sellAllCards.Checked = setting.SellTransferList;
            }
        }

        private void ClearAllFields()
        {
            txt_settingSaveName.Text = null;
            txt_buyPrice.Text = null;
            txt_listPrice.Text = null;
            chk_sellBoughtCard.Checked = false;
            chk_sellAllCards.Checked = false; 
        }
    }
}
