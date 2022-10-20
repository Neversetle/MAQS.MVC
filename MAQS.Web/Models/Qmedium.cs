using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Qmedium
    {
        public string Medianame { get; set; } = null!;
        public string? Mediagroup { get; set; }
        public bool? Expired { get; set; }
        public bool? Nonmedia { get; set; }
        public bool? Internet { get; set; }
        public short? Admaxcols { get; set; }
        public decimal? Admaxdepth { get; set; }
        public decimal? Colsize { get; set; }
        public decimal? Defdimcol { get; set; }
        public decimal? Defdimrow { get; set; }
        public bool? Onlychoice { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string? Lastrevby { get; set; }
        public DateTime? Lastrevdat { get; set; }
        public bool? Nocomiss { get; set; }
        public bool? Notsendtsh { get; set; }
        public int? Chksum4 { get; set; }
        public string? Quickgroup { get; set; }
        public string? Quickname { get; set; }
        public byte? Pagesize { get; set; }
        public byte? Pubsubg { get; set; }
        public byte? Pubtype { get; set; }
        public bool? Preset { get; set; }
        public byte? Ted { get; set; }
        public bool? Givetoint { get; set; }
        public string? Mcolsize { get; set; }
        public string? Mrowsize { get; set; }
        public byte? Mediatype { get; set; }
        public string? Glcode { get; set; }
        public string? Deptname { get; set; }
    }
}
