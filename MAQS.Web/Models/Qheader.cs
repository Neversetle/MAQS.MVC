using System;
using System.Collections.Generic;

namespace MAQS.Web.Models
{
    public partial class Qheader
    {
        public string Contactid { get; set; } = null!;
        public int Quotenum { get; set; }
        public short Qinvnum { get; set; }
        public string Qcompany { get; set; } = null!;
        public string Qcontact { get; set; } = null!;
        public string Qconttitle { get; set; } = null!;
        public string Qconad1 { get; set; } = null!;
        public string Qconad2 { get; set; } = null!;
        public string Qconcity { get; set; } = null!;
        public string Qconst { get; set; } = null!;
        public string Qconzip { get; set; } = null!;
        public string Qconphon { get; set; } = null!;
        public string Qconfax { get; set; } = null!;
        public string Qconemail { get; set; } = null!;
        public string Qconurl { get; set; } = null!;
        public double Qdiscper1 { get; set; }
        public double Qdisctot1 { get; set; }
        public double Qdiscper2 { get; set; }
        public TimeSpan Qdisctot2 { get; set; }
        public double Qdiscprice { get; set; }
        public TimeSpan Qadjustment { get; set; }
        public double Qsubtotal { get; set; }
        public double Qtotal { get; set; }
        public double Qagdiscper { get; set; }
        public double Qagdisctot { get; set; }
        public DateTime Qcreatedat { get; set; }
        public string Qcreateby { get; set; } = null!;
        public DateTime Qupdtdate { get; set; }
        public string Qupdtby { get; set; } = null!;
        public DateTime Qconfdate { get; set; }
        public string Qconfby { get; set; } = null!;
        public string Qcancdat { get; set; } = null!;
        public string Qcancby { get; set; } = null!;
        public string? Qadtext { get; set; }
        public string QagcCont { get; set; } = null!;
        public string QagcComp { get; set; } = null!;
        public string QagcAdd1 { get; set; } = null!;
        public string QagcAdd2 { get; set; } = null!;
        public string QagcCity { get; set; } = null!;
        public string QagcState { get; set; } = null!;
        public string QagcZip { get; set; } = null!;
        public TimeSpan QagcDisc { get; set; }
        public string QfaxSubj { get; set; } = null!;
        public string? QfaxComm { get; set; }
        public string QuserName { get; set; } = null!;
        public string? Qcomment { get; set; }
        public string? Qagreement { get; set; }
        public string QxmitType { get; set; } = null!;
        public byte QxmitCnt { get; set; }
        public string Qlogos { get; set; } = null!;
        public string QadcomingTyp { get; set; } = null!;
        public double Qtotallist { get; set; }
        public byte QreissueInv { get; set; }
        public TimeSpan Qtotalprdisc { get; set; }
        public string QagcPhone { get; set; } = null!;
        public string QagcFax { get; set; } = null!;
        public string QagcEmail { get; set; } = null!;
        public bool Ordertaken { get; set; }
        public bool Confirmed { get; set; }
        public bool Billed { get; set; }
        public bool Cancelled { get; set; }
        public bool Adcopyhere { get; set; }
        public byte Adcopycoming { get; set; }
        public byte Cameraready { get; set; }
        public bool Adcopyin { get; set; }
        public bool Adproofreq { get; set; }
        public byte Adproofsent { get; set; }
        public byte Adproofin { get; set; }
        public bool Crproofreq { get; set; }
        public byte Newforprod { get; set; }
        public bool Newforacct { get; set; }
        public short Billaddr1 { get; set; }
        public byte Billaddr2 { get; set; }
        public byte Billaddr3 { get; set; }
        public byte Billaddr4 { get; set; }
        public int? Ponum { get; set; }
        public byte Prtaddr1lbl { get; set; }
        public byte Prtaddr2lbl { get; set; }
        public byte Prtaddr3lbl { get; set; }
        public byte Prtaddr4lbl { get; set; }
        public byte Prtaddr5lbl { get; set; }
        public byte Qstatus { get; set; }
        public bool Admethod { get; set; }
        public string Intcdate { get; set; } = null!;
        public string Applyemail { get; set; } = null!;
        public byte Newafterclose { get; set; }
        public bool Closed { get; set; }
        public bool Swapad { get; set; }
        public bool Inhouse { get; set; }
        public bool Nointernet { get; set; }
        public byte Pickup { get; set; }
        public string Pickupad { get; set; } = null!;
        public byte Adproofadd { get; set; }
        public string Qbilldate { get; set; } = null!;
        public string Intcdate2 { get; set; } = null!;
        public string Qgroup { get; set; } = null!;
        public int Chksum1 { get; set; }
        public int Chksum2 { get; set; }
        public string Terrcode { get; set; } = null!;
        public string Agcyid { get; set; } = null!;
        public string Gpbatch { get; set; } = null!;
        public string Accountid { get; set; } = null!;
        public DateTime Tobebilled { get; set; }
        public bool Reconfirm { get; set; }
        public byte Gpbatch1 { get; set; }
        public byte Webcoming { get; set; }
        public byte Webreceivd { get; set; }
        public byte Callpendin { get; set; }
        public string Rmsetup { get; set; } = null!;
        public string Rmloaded { get; set; } = null!;
        public string Rmxdate { get; set; } = null!;
        public byte Rmailsent { get; set; }
        public string Rmdemodate { get; set; } = null!;
        public string Rmcomment { get; set; } = null!;
        public byte Dsskillsetreceived { get; set; }
        public byte Dsstatereceived { get; set; }
        public byte Dspositionreceived { get; set; }
        public string Corpid { get; set; } = null!;
        public byte JfQuest { get; set; }
        public byte JfJobs { get; set; }
        public byte JfProfile { get; set; }
        public byte Cpcomplete { get; set; }
        public byte Cscomplete { get; set; }
        public string Ordertakendate { get; set; } = null!;
        public byte InboundSales { get; set; }
        public byte ClientIssue { get; set; }
        public string ClientIssueDate { get; set; } = null!;
        public byte IssueResolved { get; set; }
        public string IssueResolvedDate { get; set; } = null!;
    }
}
