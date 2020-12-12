using System.Collections.Generic;

namespace FIFAAutoBuyer_Client.Models
{
    public static class AppConstants
    {
        public static List<string> SearchColumnsToHide = new List<string> { "ABSetting" , "SettingID", "PkId", "Position", "ChemistryStyle", "Nationality",
                                                          "League", "Club", "PriceCalculatedAt" };

        public static List<string> SettingsColumnsToHide = new List<string> { "MaxRandomBidPrice" , "CalcBuyPrice", "PkId", "PlayerSearchCriteria", "BidPrice", "CalcBuyPrice",
                                                          "CalcListPrice"};
    }
}
