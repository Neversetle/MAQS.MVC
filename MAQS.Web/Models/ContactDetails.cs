using System.ComponentModel.DataAnnotations;

namespace MAQS.Web.Models
{
    public class ContactDetails
    {       
        public string? Company { get; set; }
        public string? Contact { get; set; }
        public string? Title { get; set; }

        public string? Address2 { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }

        public string? Phone { get; set; }
        public string? Altphone { get; set; }
        public string? Urlweb { get; set; }

        public string? Zip { get; set; }
        [Key]
        public string Email { get; set; }
        public string? Address1 { get; set; }
        public string? Urlcareers { get; set; }

        public string? RcinotesPad { get; set; }
        public string? NgnotesPad { get; set; }
        public string? MisnotesPad { get; set; }
        public string? VisnotesPad { get; set; }

        public short Qinvnum { get; set; }
        public string? Qcontact { get; set; }
        public string? Agcyid { get; set; }
        public double Qtotal { get; set; }
        public bool Confirmed { get; set; }
        public bool Cancelled { get; set; }

    }
}
