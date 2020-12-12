namespace FIFAAutoBuyer_Client.Models
{
    public class Account
    {
        public object PkId { get; set; }

        public string Email { get; set; }

        public PlatForm PlatForm { get; set; }

        public string Status { get; set; } = "Not Logged In";
    }
}
