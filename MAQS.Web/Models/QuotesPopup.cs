using System.ComponentModel.DataAnnotations;

namespace MAQS.Web.Models
{
    public class QuotesPopup
    {
        [Key]
        public int Quotenum { get; set; }
        public string? Qcompany { get; set; } 
        public string? Qconad2 { get; set; }
        public string? Qconcity { get; set; }
        public string? Qconst { get; set; }
        public string? Qconurl { get; set; }
        public string? Qcreateby { get; set; }
        public string? Qupdtby { get; set; }
        public string? Qconfby { get; set; }
        public string? Qcancby { get; set; }
        public short? Qinvnum { get; set; }
        public string? Qconad1 { get; set; }
        public string? Qconemail { get; set; }
        public string? Qcontact { get; set; }
        public string? Qconphon { get; set; }
        public string? Qconfax { get; set; }
        public string? Qconzip { get; set; }
        public decimal? Qmedprice { get; set; }
        public decimal? Qmedsubtotal { get; set; }
        public decimal? Qmedadicdisc { get; set; }
        public decimal? Qmedagdisctot { get; set; }
        public decimal? Qmedtotal { get; set; }
        public double? Qtotallist { get; set; }
        public double? Qtotal { get; set; }
        public double? Qagdiscper { get; set; }
        public double? Qagdisctot { get; set; }
    }
}
