using MessagePack;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace MAQS.Web.Models
{
    [Keyless]
    public class CompanyContact
    {
        public int corpid { get; set; }
        public int rowid { get; set; }
        public DateTime created { get; set; }
        public string createdby { get; set; }
        public DateTime updated { get; set; }
        public string updatedby { get; set; }
        //public Timestamp timestamp { get; set; }
        public bool delrec { get; set; }
        [Required]
        public string company { get; set; }
        public string contact { get; set; }
        public string title { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string pharea { get; set; }
        public string phone { get; set; }
        public string phext { get; set; }
        public string phtype { get; set; }
        public string altpharea { get; set; }
        public string altphone { get; set; }
        public string altphext { get; set; }
        public string altphtype { get; set; }
        public string pharea800 { get; set; }
        public string phone800 { get; set; }
        public string faxarea { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string urlweb { get; set; }
        public int agcorpid { get; set; }
        public string prvemp { get; set; }
        public string skillset { get; set; }
        public string status { get; set; }
        public string lpcode { get; set; }
        public string contactid2 { get; set; }
        public int parentid { get; set; }
        public string persemail { get; set; }
        public string urlcareers { get; set; }
        public string position { get; set; }
    }
}
