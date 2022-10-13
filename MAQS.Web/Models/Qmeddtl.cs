using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Qmeddtl
    {
        public string? Medianame { get; set; }
        public DateTime? Issuedate { get; set; }
        public DateTime? Deadline { get; set; }
        public string? Deadlinet { get; set; }
        public DateTime? Matdeadlin { get; set; }
        public DateTime? Compaiddat { get; set; }
        public bool? Soldout { get; set; }
        public decimal? Medrate { get; set; }
        public decimal? Minprice { get; set; }
        public decimal? Maxprice { get; set; }
        public decimal? Colorcharg { get; set; }
        public string Mediaissue { get; set; } = null!;
        public int? Chksum5 { get; set; }
        public DateTime? Osd { get; set; }
        public decimal? Maxdisc { get; set; }
        public decimal? Medrate2 { get; set; }
        public decimal? Medrate3 { get; set; }
    }
}
