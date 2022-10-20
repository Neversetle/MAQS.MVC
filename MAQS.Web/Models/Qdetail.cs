using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Qdetail
    {
        public string? Contactid { get; set; }
        public int Quotenum { get; set; }
        public int Lineid { get; set; }
        public string? Qmeddesc { get; set; }
        public bool? Qnonmedia { get; set; }
        public bool? Qinternet { get; set; }
        public DateTime? Qmeddate { get; set; }
        public decimal? Qmeddimcol { get; set; }
        public decimal? Qmeddimrow { get; set; }
        public short? Qmedqty { get; set; }
        public decimal? Qmedprice { get; set; }
        public decimal? Qmeddisc { get; set; }
        public decimal? Qmeddiscp { get; set; }
        public bool? Qmedcolor { get; set; }
        public decimal? Qmedcolorprice { get; set; }
        public decimal? Qmedsubtotal { get; set; }
        public decimal? Qmeddiscper { get; set; }
        public decimal? Qmeddisctot { get; set; }
        public decimal? Qmedadicdisc { get; set; }
        public decimal? Qmedagdisctot { get; set; }
        public decimal? Qmedtotal { get; set; }
        public decimal? QminPrice { get; set; }
        public decimal? QmaxPrice { get; set; }
        public bool? Qmedcamerain { get; set; }
        public bool? Qmedcrproofin { get; set; }
        public bool? Qmedprodcomp { get; set; }
        public bool? Qmedbump { get; set; }
        public string? Mediaissue { get; set; }
        public int? Qmedvoid { get; set; }
        public string? Qmedadnum { get; set; }
        public bool? Qmednewforprod { get; set; }
        public bool? Qmedreissued { get; set; }
        public bool? Qmednewforprod1 { get; set; }
        public byte? Qmedrevision { get; set; }
        public bool? Qmedignoresale { get; set; }
        public bool? Qmednotsendtsh { get; set; }
        public short? Mgzpage { get; set; }
        public bool? Mgzfixpage { get; set; }
        public bool? Mgzfixpos { get; set; }
        public short? Mgzcol { get; set; }
        public short? Mgzrow { get; set; }
        public int? Chksum3 { get; set; }
    }
}
