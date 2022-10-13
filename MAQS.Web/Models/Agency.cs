using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Agency
    {
        public Guid Corpid { get; set; }
        public int Rowid { get; set; }
        public DateTime? Created { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public string? Updatedby { get; set; }
        public byte[]? Timestamp { get; set; }
        public bool? Delrec { get; set; }
        public string? Company { get; set; }
        public string? Contact { get; set; }
        public string? Title { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Pharea { get; set; }
        public string? Phone { get; set; }
        public string? Phext { get; set; }
        public string? Phtype { get; set; }
        public string? Altpharea { get; set; }
        public string? Altphone { get; set; }
        public string? Altphext { get; set; }
        public string? Altphtype { get; set; }
        public string? Faxarea { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Urlweb { get; set; }
        public string? Status { get; set; }
        public string? Contactid2 { get; set; }
    }
}
