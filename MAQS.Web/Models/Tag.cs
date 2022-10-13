using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Tag
    {
        public Guid Corpid { get; set; }
        public string Userid { get; set; } = null!;
        public bool? Tagcheck { get; set; }
        public DateTime? Tagdate { get; set; }
        public byte? Tagtype { get; set; }
        public string? Wavefile { get; set; }
    }
}
