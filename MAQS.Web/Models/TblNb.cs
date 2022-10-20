using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class TblNb
    {
        public int Nbid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Pincode { get; set; }
        public string? Address { get; set; }
    }
}
