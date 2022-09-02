using FIFAAutoBuyer_Client.Helpers;
using FIFAAutoBuyer_Client.Models;
using FIFAAutoBuyer_Lib.DataModels;
using FIFAAutoBuyer_Lib.Domain;
using FIFAAutoBuyer_Lib.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class SearchList : BaseForm
    { 
        public SearchList()
        {
            InitializeComponent();
            HideSearchForm();
            cmb_srchPlayerQuality.DataSource = DropDownHelper.GetQualities();
            cmb_srchPlayerRarity.DataSource = DropDownHelper.GetRarities();
            cmb_srchPlayerLeague.DataSource = DropDownHelper.GetLeagues();
            cmb_srchPlayerClub.DataSource = DropDownHelper.GetClubs();

            var abSettings = new List<DropDownOption>
            {
              new DropDownOption{ Id = -1, DisplayValue = "-- AB Setting --" }
            };
            abSettings.AddRange(SettingDAL.GetSettings().Select(a => new DropDownOption { Id = a.PkId, DisplayValue = a.Name }));
            cmb_abSettings.DataSource = abSettings;

            ac_playerName.DataSource = SearchDAL.GetPlayersForAutoSuggest().Select(a => a.DisplayName).Distinct().ToList(); 
        }

        private void btn_editCancel_Click(object sender, EventArgs e)
        {
            tab_searchPlayer.Controls.ResetAllControls();
            HideSearchForm();
        }

        private void btn_editSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_searchSaveName.Text))
            {
                MessageBox.Show("Search Name Required");
                return;
            }

            PlayerSearchCriteria criteria = GetSearchCritieriaFromForm();

            if (grd_searchList.SelectedRows.Count > 0)
            {
                object pkId = grd_searchList.SelectedRows[0].Cells["PkId"].Value;
                criteria.PkId = Convert.ToInt32(pkId);
                SearchDAL.UpdateSearch(criteria);
            }
            else
            {
                SearchDAL.SaveSearch(criteria);
            }

            SearchList_Load(sender, e);

            HideSearchForm();
        }

        private void btn_editSearch_Click(object sender, EventArgs e)
        {
            if (grd_searchList.SelectedRows.Count > 0)
            {
                object pkId = grd_searchList.SelectedRows[0].Cells["PkId"].Value;
                PlayerSearchCriteria criteria = SearchDAL.GetSearch<PlayerSearchCriteria>(pkId);

                FillFormFormCriteria(criteria);
            }

            ShowSearchForm();
        }

        private void btn_newSearch_Click(object sender, EventArgs e)
        {
            tab_searchPlayer.Controls.ResetAllControls();
            grd_searchList.ClearSelection();
            ShowSearchForm();
        }

        private void btn_deleteSearch_Click(object sender, EventArgs e)
        {
            if (grd_searchList.SelectedRows.Count > 0)
            {
                object pkId = grd_searchList.SelectedRows[0].Cells["PkId"].Value;
                SearchDAL.DeleteSearch<PlayerSearchCriteria>(pkId);

                tab_searchPlayer.Controls.ResetAllControls();

                SearchList_Load(sender, e);
            }

            HideSearchForm();
        }

        private void ShowSearchForm()
        {
            grd_searchList.Height = 269;
            trans_searchForm.Show(panel_SearchForm);
        }

        private void HideSearchForm()
        {
            trans_searchForm.HideSync(panel_SearchForm);
            grd_searchList.Height = 607;
        }

        private void grd_searchList_SelectionChanged(object sender, EventArgs e)
        {
            HideSearchForm();

            if (grd_searchList.SelectedRows.Count > 0)
            {
                btn_editSearch.Visible = true;
                btn_deleteSearch.Visible = true;
            }
            else
            {
                btn_editSearch.Visible = false;
                btn_deleteSearch.Visible = false;
            }
        }

        public override void Show(bool isOpen)
        {
            base.Show();

            if (isOpen)
            {
                btn_newSearch_Click(null, null);
            }
        } 

        private void grd_searchList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grd_searchList.ClearSelection();
            grd_searchList.HideColumns(AppConstants.SearchColumnsToHide);
        }

        private void SearchList_Load(object sender, EventArgs e)
        {
            List<PlayerSearchCriteria> playerSearchCriterias = SearchDAL.GetSearches<PlayerSearchCriteria>();
            grd_searchList.DataSource = playerSearchCriterias.ToDataTable();

            if (playerSearchCriterias.Any())
            {
                lbl_noSearches.Visible = false;
                grd_searchList.Visible = true;
            }
            else
            {
                lbl_noSearches.Visible = true;
                grd_searchList.Visible = false;
            }
        }

        private void cmb_srchPlayerQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filterId = -1;
            if (cmb_srchPlayerQuality.SelectedValue != null)
            {
                DropDownOption selectedOption = cmb_srchPlayerQuality.SelectedValue as DropDownOption;
                filterId = selectedOption.Id;
            }
            cmb_srchPlayerRarity.DataSource = DropDownHelper.GetRarities(filterId);
        }

        private void cmb_srchPlayerLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filterId = -1;
            if (cmb_srchPlayerLeague.SelectedValue != null)
            {
                DropDownOption selectedOption = cmb_srchPlayerLeague.SelectedValue as DropDownOption;
                filterId = selectedOption.Id;
            }
            cmb_srchPlayerClub.DataSource = DropDownHelper.GetClubs(filterId);
        }

        private PlayerSearchCriteria GetSearchCritieriaFromForm()
        {
            PlayerSearchCriteria criteria = new PlayerSearchCriteria
            {
                Name = txt_searchSaveName.Text,
                PlayerName = ac_playerName.Text,
                ChemistryStyle = GetComboBoxValue(cmb_srchPlayerStyle),
                Club = GetComboBoxValue(cmb_srchPlayerClub),
                League = GetComboBoxValue(cmb_srchPlayerLeague),
                Nationality = GetComboBoxValue(cmb_srchPlayerNationality),
                Position = GetComboBoxValue(cmb_srchPlayerPosition),
                Rarity = GetComboBoxValue(cmb_srchPlayerRarity),
                Quality = GetComboBoxValue(cmb_srchPlayerQuality),
                MaxBid = txt_srchPlayerBidMax.Text,
                MinBid = txt_srchPlayerBidMin.Text,
                MaxBin = txt_srchPlayerBinMax.Text,
                MinBin = txt_srchPlayerBinMin.Text,
                SettingId = GetSettingId(),
            };

            return criteria;
        }
        private int GetSettingId()
        {
            string idString = cmb_abSettings.SelectedValue + "";

            if (string.IsNullOrEmpty(idString) || idString == "-1")
            {
                return 0;
            }

            return Convert.ToInt32(idString);
        }

        private string GetComboBoxValue(Guna2ComboBox comboBox)
        {
            if (comboBox.Text?.IndexOf("--") == -1)
            {
                return comboBox.Text;
            }

            return null;
        }

        private void FillFormFormCriteria(PlayerSearchCriteria playerSearchCriteria)
        { 
            if (playerSearchCriteria != null)
            {
                txt_searchSaveName.Text = playerSearchCriteria.Name;
                ac_playerName.Text = playerSearchCriteria.PlayerName;
                cmb_srchPlayerStyle.Text = playerSearchCriteria.ChemistryStyle ?? "-- Chemistry Style -- ";
                cmb_srchPlayerLeague.Text = playerSearchCriteria.League ?? "-- League --";
                cmb_srchPlayerClub.Text = playerSearchCriteria.Club ?? "-- Club --";
                cmb_srchPlayerNationality.Text = playerSearchCriteria.Nationality ?? "-- Nationality -- ";
                cmb_srchPlayerPosition.Text = playerSearchCriteria.Position ?? "-- Position -- ";
                cmb_srchPlayerQuality.Text = playerSearchCriteria.Quality ?? "-- Quality --";
                cmb_srchPlayerRarity.Text = playerSearchCriteria.Rarity ?? "-- Rarity --";
                txt_srchPlayerBidMax.Text = playerSearchCriteria.MaxBid;
                txt_srchPlayerBidMin.Text = playerSearchCriteria.MinBid;
                txt_srchPlayerBinMax.Text = playerSearchCriteria.MaxBin;
                txt_srchPlayerBinMin.Text = playerSearchCriteria.MinBin;
                cmb_abSettings.SelectedValue = playerSearchCriteria.SettingId ?? -1;
            }
        }

        private void lnk_newSetting_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Parent.Parent as MainForm;
            mainForm.FormChangeEvent("setting");
        }
    }
}
