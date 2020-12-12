using System;

namespace FIFAAutoBuyer_Client.Models
{
    [Serializable]
   public class AutoSuggest
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
