using System.Collections.Generic;

namespace FIFAAutoBuyer_Client.Models
{
    public class DropDownOption
    {
        public int Id { get; set; }
        public HashSet<int> ParentId { get; set; }
        public string DisplayValue { get; set; }
    }

    public class DropDownCheckOption : DropDownOption
    {
        public bool IsChecked { get; set; } 
    }
}
