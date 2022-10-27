using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MAQS.Web.Models
{
    public partial class maqsdbContext : DbContext
    {
        public maqsdbContext()
        {
        }

        public maqsdbContext(DbContextOptions<maqsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agency> Agencies { get; set; } = null!;
        public DbSet<CorpData> CorpDatas { get; set; }=null!;
        public virtual DbSet<Corp> Corps { get; set; } = null!;
        public virtual DbSet<Misnote> Misnotes { get; set; } = null!;
        public virtual DbSet<Ngnote> Ngnotes { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;
        public virtual DbSet<Qdetail> Qdetails { get; set; } = null!;
        public virtual DbSet<Qheader> Qheaders { get; set; } = null!;
        public virtual DbSet<Qmeddtl> Qmeddtls { get; set; } = null!;
        public virtual DbSet<Qmedium> Qmedia { get; set; } = null!;
        public virtual DbSet<Rcinote> Rcinotes { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<TblNb> TblNbs { get; set; } = null!;
        public virtual DbSet<Visnote> Visnotes { get; set; } = null!;
        public virtual DbSet<ContactDetails> ContactDetailss { get; set; } = null!;
        public virtual DbSet<QuotesPopup> QuotesPopups { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=maqsdbserver.database.windows.net;Database=maqsdb;Persist Security Info=True;User ID=maqsadmin;Password=maqsdb@123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>(entity =>
            {
                entity.HasKey(e => e.Corpid);

                entity.ToTable("agencies");

                entity.Property(e => e.Corpid)
                    .ValueGeneratedNever()
                    .HasColumnName("corpid");

                entity.Property(e => e.Address1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Altpharea)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("altpharea");

                entity.Property(e => e.Altphext)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("altphext");

                entity.Property(e => e.Altphone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("altphone");

                entity.Property(e => e.Altphtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("altphtype");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Contact)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Contactid2)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("contactid2");

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Delrec).HasColumnName("delrec");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Faxarea)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("faxarea");

                entity.Property(e => e.Pharea)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pharea");

                entity.Property(e => e.Phext)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("phext");

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Phtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("phtype");

                entity.Property(e => e.Rowid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowid");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Urlweb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("urlweb");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<Corp>(entity =>
            {
                entity.ToTable("corp");

                entity.Property(e => e.Corpid)
                    .ValueGeneratedNever()
                    .HasColumnName("corpid");

                entity.Property(e => e.Address1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Agcorpid).HasColumnName("agcorpid");

                entity.Property(e => e.Altpharea)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("altpharea");

                entity.Property(e => e.Altphext)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("altphext");

                entity.Property(e => e.Altphone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("altphone");

                entity.Property(e => e.Altphtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("altphtype");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Contact)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Contactid2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("contactid2");

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Delrec).HasColumnName("delrec");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Faxarea)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("faxarea");

                entity.Property(e => e.Lpcode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("lpcode");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Persemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("persemail");

                entity.Property(e => e.Pharea)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pharea");

                entity.Property(e => e.Pharea800)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("pharea800");

                entity.Property(e => e.Phext)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("phext");

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Phone800)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("phone800");

                entity.Property(e => e.Phtype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("phtype");

                entity.Property(e => e.Position)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Prvemp)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("prvemp");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Skillset)
                    .HasColumnType("text")
                    .HasColumnName("skillset");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Urlcareers)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("urlcareers");

                entity.Property(e => e.Urlweb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("urlweb");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<Misnote>(entity =>
            {
                entity.HasKey(e => e.Corpid);

                entity.ToTable("misnotes");

                entity.Property(e => e.Corpid)
                    .ValueGeneratedNever()
                    .HasColumnName("corpid");

                entity.Property(e => e.MisnotesPad)
                    .HasColumnType("text")
                    .HasColumnName("notes_pad");
            });

            modelBuilder.Entity<Ngnote>(entity =>
            {
                entity.HasKey(e => e.Corpid);

                entity.ToTable("ngnotes");

                entity.Property(e => e.Corpid)
                    .ValueGeneratedNever()
                    .HasColumnName("corpid");

                entity.Property(e => e.NgnotesPad)
                    .HasColumnType("text")
                    .HasColumnName("notes_pad");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("notes");

                entity.Property(e => e.Noteid).HasColumnName("noteid");

                entity.Property(e => e.Corpid).HasColumnName("corpid");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Incrm).HasColumnName("incrm");

                entity.Property(e => e.Notepad)
                    .HasColumnType("text")
                    .HasColumnName("notepad");

                entity.Property(e => e.Source)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<Qdetail>(entity =>
            {
                entity.HasKey(e => new { e.Quotenum, e.Lineid });

                entity.ToTable("qdetail");

                entity.Property(e => e.Quotenum).HasColumnName("quotenum");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Chksum3).HasColumnName("chksum3");

                entity.Property(e => e.Contactid)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("contactid")
                    .IsFixedLength();

                entity.Property(e => e.Mediaissue)
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("mediaissue")
                    .IsFixedLength();

                entity.Property(e => e.Mgzcol).HasColumnName("mgzcol");

                entity.Property(e => e.Mgzfixpage).HasColumnName("mgzfixpage");

                entity.Property(e => e.Mgzfixpos).HasColumnName("mgzfixpos");

                entity.Property(e => e.Mgzpage).HasColumnName("mgzpage");

                entity.Property(e => e.Mgzrow).HasColumnName("mgzrow");

                entity.Property(e => e.Qinternet).HasColumnName("qinternet");

                entity.Property(e => e.QmaxPrice)
                    .HasColumnType("money")
                    .HasColumnName("qmax_price");

                entity.Property(e => e.Qmedadicdisc)
                    .HasColumnType("money")
                    .HasColumnName("qmedadicdisc");

                entity.Property(e => e.Qmedadnum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("qmedadnum")
                    .IsFixedLength();

                entity.Property(e => e.Qmedagdisctot)
                    .HasColumnType("money")
                    .HasColumnName("qmedagdisctot");

                entity.Property(e => e.Qmedbump).HasColumnName("qmedbump");

                entity.Property(e => e.Qmedcamerain).HasColumnName("qmedcamerain");

                entity.Property(e => e.Qmedcolor).HasColumnName("qmedcolor");

                entity.Property(e => e.Qmedcolorprice)
                    .HasColumnType("money")
                    .HasColumnName("qmedcolorprice");

                entity.Property(e => e.Qmedcrproofin).HasColumnName("qmedcrproofin");

                entity.Property(e => e.Qmeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("qmeddate");

                entity.Property(e => e.Qmeddesc)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("qmeddesc")
                    .IsFixedLength();

                entity.Property(e => e.Qmeddimcol)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("qmeddimcol");

                entity.Property(e => e.Qmeddimrow)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("qmeddimrow");

                entity.Property(e => e.Qmeddisc)
                    .HasColumnType("numeric(6, 3)")
                    .HasColumnName("qmeddisc");

                entity.Property(e => e.Qmeddiscp)
                    .HasColumnType("money")
                    .HasColumnName("qmeddiscp");

                entity.Property(e => e.Qmeddiscper)
                    .HasColumnType("numeric(8, 3)")
                    .HasColumnName("qmeddiscper");

                entity.Property(e => e.Qmeddisctot)
                    .HasColumnType("money")
                    .HasColumnName("qmeddisctot");

                entity.Property(e => e.Qmedignoresale).HasColumnName("qmedignoresale");

                entity.Property(e => e.Qmednewforprod).HasColumnName("qmednewforprod");

                entity.Property(e => e.Qmednewforprod1).HasColumnName("qmednewforprod1");

                entity.Property(e => e.Qmednotsendtsh).HasColumnName("qmednotsendtsh");

                entity.Property(e => e.Qmedprice)
                    .HasColumnType("money")
                    .HasColumnName("qmedprice");

                entity.Property(e => e.Qmedprodcomp).HasColumnName("qmedprodcomp");

                entity.Property(e => e.Qmedqty).HasColumnName("qmedqty");

                entity.Property(e => e.Qmedreissued).HasColumnName("qmedreissued");

                entity.Property(e => e.Qmedrevision).HasColumnName("qmedrevision");

                entity.Property(e => e.Qmedsubtotal)
                    .HasColumnType("money")
                    .HasColumnName("qmedsubtotal");

                entity.Property(e => e.Qmedtotal)
                    .HasColumnType("money")
                    .HasColumnName("qmedtotal");

                entity.Property(e => e.Qmedvoid).HasColumnName("qmedvoid");

                entity.Property(e => e.QminPrice)
                    .HasColumnType("money")
                    .HasColumnName("qmin_price");

                entity.Property(e => e.Qnonmedia).HasColumnName("qnonmedia");
            });

            modelBuilder.Entity<Qheader>(entity =>
            {
                entity.HasKey(e => e.Quotenum);

                entity.ToTable("qheader");

                entity.Property(e => e.Quotenum)
                    .ValueGeneratedNever()
                    .HasColumnName("quotenum");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(50)
                    .HasColumnName("accountid");

                entity.Property(e => e.Adcopycoming).HasColumnName("adcopycoming");

                entity.Property(e => e.Adcopyhere).HasColumnName("adcopyhere");

                entity.Property(e => e.Adcopyin).HasColumnName("adcopyin");

                entity.Property(e => e.Admethod).HasColumnName("admethod");

                entity.Property(e => e.Adproofadd).HasColumnName("adproofadd");

                entity.Property(e => e.Adproofin).HasColumnName("adproofin");

                entity.Property(e => e.Adproofreq).HasColumnName("adproofreq");

                entity.Property(e => e.Adproofsent).HasColumnName("adproofsent");

                entity.Property(e => e.Agcyid)
                    .HasMaxLength(50)
                    .HasColumnName("agcyid");

                entity.Property(e => e.Applyemail)
                    .HasMaxLength(50)
                    .HasColumnName("applyemail");

                entity.Property(e => e.Billaddr1).HasColumnName("billaddr1");

                entity.Property(e => e.Billaddr2).HasColumnName("billaddr2");

                entity.Property(e => e.Billaddr3).HasColumnName("billaddr3");

                entity.Property(e => e.Billaddr4).HasColumnName("billaddr4");

                entity.Property(e => e.Billed).HasColumnName("billed");

                entity.Property(e => e.Callpendin).HasColumnName("callpendin");

                entity.Property(e => e.Cameraready).HasColumnName("cameraready");

                entity.Property(e => e.Cancelled).HasColumnName("cancelled");

                entity.Property(e => e.Chksum1).HasColumnName("chksum1");

                entity.Property(e => e.Chksum2).HasColumnName("chksum2");

                entity.Property(e => e.ClientIssueDate).HasMaxLength(50);

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.Contactid)
                    .HasMaxLength(50)
                    .HasColumnName("contactid");

                entity.Property(e => e.Corpid)
                    .HasMaxLength(50)
                    .HasColumnName("corpid");

                entity.Property(e => e.Cpcomplete).HasColumnName("cpcomplete");

                entity.Property(e => e.Crproofreq).HasColumnName("crproofreq");

                entity.Property(e => e.Cscomplete).HasColumnName("cscomplete");

                entity.Property(e => e.Dspositionreceived).HasColumnName("dspositionreceived");

                entity.Property(e => e.Dsskillsetreceived).HasColumnName("dsskillsetreceived");

                entity.Property(e => e.Dsstatereceived).HasColumnName("dsstatereceived");

                entity.Property(e => e.Gpbatch)
                    .HasMaxLength(50)
                    .HasColumnName("gpbatch");

                entity.Property(e => e.Gpbatch1).HasColumnName("gpbatch1");

                entity.Property(e => e.Inhouse).HasColumnName("inhouse");

                entity.Property(e => e.Intcdate)
                    .HasMaxLength(50)
                    .HasColumnName("intcdate");

                entity.Property(e => e.Intcdate2)
                    .HasMaxLength(50)
                    .HasColumnName("intcdate2");

                entity.Property(e => e.IssueResolvedDate).HasMaxLength(50);

                entity.Property(e => e.JfJobs).HasColumnName("jf_jobs");

                entity.Property(e => e.JfProfile).HasColumnName("jf_profile");

                entity.Property(e => e.JfQuest).HasColumnName("jf_quest");

                entity.Property(e => e.Newafterclose).HasColumnName("newafterclose");

                entity.Property(e => e.Newforacct).HasColumnName("newforacct");

                entity.Property(e => e.Newforprod).HasColumnName("newforprod");

                entity.Property(e => e.Nointernet).HasColumnName("nointernet");

                entity.Property(e => e.Ordertaken).HasColumnName("ordertaken");

                entity.Property(e => e.Ordertakendate)
                    .HasMaxLength(50)
                    .HasColumnName("ordertakendate");

                entity.Property(e => e.Pickup).HasColumnName("pickup");

                entity.Property(e => e.Pickupad)
                    .HasMaxLength(50)
                    .HasColumnName("pickupad");

                entity.Property(e => e.Ponum).HasColumnName("ponum");

                entity.Property(e => e.Prtaddr1lbl).HasColumnName("prtaddr1lbl");

                entity.Property(e => e.Prtaddr2lbl).HasColumnName("prtaddr2lbl");

                entity.Property(e => e.Prtaddr3lbl).HasColumnName("prtaddr3lbl");

                entity.Property(e => e.Prtaddr4lbl).HasColumnName("prtaddr4lbl");

                entity.Property(e => e.Prtaddr5lbl).HasColumnName("prtaddr5lbl");

                entity.Property(e => e.QadcomingTyp)
                    .HasMaxLength(50)
                    .HasColumnName("qadcoming_typ");

                entity.Property(e => e.Qadjustment).HasColumnName("qadjustment");

                entity.Property(e => e.Qadtext)
                    .HasMaxLength(1100)
                    .HasColumnName("qadtext");

                entity.Property(e => e.QagcAdd1)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_add1");

                entity.Property(e => e.QagcAdd2)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_add2");

                entity.Property(e => e.QagcCity)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_city");

                entity.Property(e => e.QagcComp)
                    .HasMaxLength(100)
                    .HasColumnName("qagc_comp");

                entity.Property(e => e.QagcCont)
                    .HasMaxLength(100)
                    .HasColumnName("qagc_cont");

                entity.Property(e => e.QagcDisc).HasColumnName("qagc_disc");

                entity.Property(e => e.QagcEmail)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_email");

                entity.Property(e => e.QagcFax)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_fax");

                entity.Property(e => e.QagcPhone)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_phone");

                entity.Property(e => e.QagcState)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_state");

                entity.Property(e => e.QagcZip)
                    .HasMaxLength(50)
                    .HasColumnName("qagc_zip");

                entity.Property(e => e.Qagdiscper).HasColumnName("qagdiscper");

                entity.Property(e => e.Qagdisctot).HasColumnName("qagdisctot");

                entity.Property(e => e.Qagreement)
                    .HasMaxLength(2950)
                    .HasColumnName("qagreement");

                entity.Property(e => e.Qbilldate)
                    .HasMaxLength(50)
                    .HasColumnName("qbilldate");

                entity.Property(e => e.Qcancby)
                    .HasMaxLength(50)
                    .HasColumnName("qcancby");

                entity.Property(e => e.Qcancdat)
                    .HasMaxLength(50)
                    .HasColumnName("qcancdat");

                entity.Property(e => e.Qcomment)
                    .HasMaxLength(1950)
                    .HasColumnName("qcomment");

                entity.Property(e => e.Qcompany)
                    .HasMaxLength(50)
                    .HasColumnName("qcompany");

                entity.Property(e => e.Qconad1)
                    .HasMaxLength(100)
                    .HasColumnName("qconad1");

                entity.Property(e => e.Qconad2)
                    .HasMaxLength(50)
                    .HasColumnName("qconad2");

                entity.Property(e => e.Qconcity)
                    .HasMaxLength(50)
                    .HasColumnName("qconcity");

                entity.Property(e => e.Qconemail)
                    .HasMaxLength(50)
                    .HasColumnName("qconemail");

                entity.Property(e => e.Qconfax)
                    .HasMaxLength(50)
                    .HasColumnName("qconfax");

                entity.Property(e => e.Qconfby)
                    .HasMaxLength(50)
                    .HasColumnName("qconfby");

                entity.Property(e => e.Qconfdate).HasColumnName("qconfdate");

                entity.Property(e => e.Qconphon)
                    .HasMaxLength(50)
                    .HasColumnName("qconphon");

                entity.Property(e => e.Qconst)
                    .HasMaxLength(50)
                    .HasColumnName("qconst");

                entity.Property(e => e.Qcontact)
                    .HasMaxLength(50)
                    .HasColumnName("qcontact");

                entity.Property(e => e.Qconttitle)
                    .HasMaxLength(50)
                    .HasColumnName("qconttitle");

                entity.Property(e => e.Qconurl)
                    .HasMaxLength(100)
                    .HasColumnName("qconurl");

                entity.Property(e => e.Qconzip)
                    .HasMaxLength(50)
                    .HasColumnName("qconzip");

                entity.Property(e => e.Qcreateby)
                    .HasMaxLength(50)
                    .HasColumnName("qcreateby");

                entity.Property(e => e.Qcreatedat).HasColumnName("qcreatedat");

                entity.Property(e => e.Qdiscper1).HasColumnName("qdiscper1");

                entity.Property(e => e.Qdiscper2).HasColumnName("qdiscper2");

                entity.Property(e => e.Qdiscprice).HasColumnName("qdiscprice");

                entity.Property(e => e.Qdisctot1).HasColumnName("qdisctot1");

                entity.Property(e => e.Qdisctot2).HasColumnName("qdisctot2");

                entity.Property(e => e.QfaxComm).HasColumnName("qfax_comm");

                entity.Property(e => e.QfaxSubj)
                    .HasMaxLength(50)
                    .HasColumnName("qfax_subj");

                entity.Property(e => e.Qgroup)
                    .HasMaxLength(50)
                    .HasColumnName("qgroup");

                entity.Property(e => e.Qinvnum).HasColumnName("qinvnum");

                entity.Property(e => e.Qlogos)
                    .HasMaxLength(50)
                    .HasColumnName("qlogos");

                entity.Property(e => e.QreissueInv).HasColumnName("qreissue_inv");

                entity.Property(e => e.Qstatus).HasColumnName("qstatus");

                entity.Property(e => e.Qsubtotal).HasColumnName("qsubtotal");

                entity.Property(e => e.Qtotal).HasColumnName("qtotal");

                entity.Property(e => e.Qtotallist).HasColumnName("qtotallist");

                entity.Property(e => e.Qtotalprdisc).HasColumnName("qtotalprdisc");

                entity.Property(e => e.Qupdtby)
                    .HasMaxLength(50)
                    .HasColumnName("qupdtby");

                entity.Property(e => e.Qupdtdate).HasColumnName("qupdtdate");

                entity.Property(e => e.QuserName)
                    .HasMaxLength(50)
                    .HasColumnName("quser_name");

                entity.Property(e => e.QxmitCnt).HasColumnName("qxmit_cnt");

                entity.Property(e => e.QxmitType)
                    .HasMaxLength(50)
                    .HasColumnName("qxmit_type");

                entity.Property(e => e.Reconfirm).HasColumnName("reconfirm");

                entity.Property(e => e.Rmailsent).HasColumnName("rmailsent");

                entity.Property(e => e.Rmcomment)
                    .HasMaxLength(100)
                    .HasColumnName("rmcomment");

                entity.Property(e => e.Rmdemodate)
                    .HasMaxLength(50)
                    .HasColumnName("rmdemodate");

                entity.Property(e => e.Rmloaded)
                    .HasMaxLength(50)
                    .HasColumnName("rmloaded");

                entity.Property(e => e.Rmsetup)
                    .HasMaxLength(50)
                    .HasColumnName("rmsetup");

                entity.Property(e => e.Rmxdate)
                    .HasMaxLength(50)
                    .HasColumnName("rmxdate");

                entity.Property(e => e.Swapad).HasColumnName("swapad");

                entity.Property(e => e.Terrcode)
                    .HasMaxLength(50)
                    .HasColumnName("terrcode");

                entity.Property(e => e.Tobebilled).HasColumnName("tobebilled");

                entity.Property(e => e.Webcoming).HasColumnName("webcoming");

                entity.Property(e => e.Webreceivd).HasColumnName("webreceivd");
            });

            modelBuilder.Entity<Qmeddtl>(entity =>
            {
                entity.HasKey(e => e.Mediaissue);

                entity.ToTable("qmeddtl");

                entity.Property(e => e.Mediaissue)
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("mediaissue")
                    .IsFixedLength();

                entity.Property(e => e.Chksum5).HasColumnName("chksum5");

                entity.Property(e => e.Colorcharg)
                    .HasColumnType("money")
                    .HasColumnName("colorcharg");

                entity.Property(e => e.Compaiddat)
                    .HasColumnType("datetime")
                    .HasColumnName("compaiddat");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasColumnName("deadline");

                entity.Property(e => e.Deadlinet)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("deadlinet")
                    .IsFixedLength();

                entity.Property(e => e.Issuedate)
                    .HasColumnType("datetime")
                    .HasColumnName("issuedate");

                entity.Property(e => e.Matdeadlin)
                    .HasColumnType("datetime")
                    .HasColumnName("matdeadlin");

                entity.Property(e => e.Maxdisc)
                    .HasColumnType("numeric(6, 3)")
                    .HasColumnName("maxdisc");

                entity.Property(e => e.Maxprice)
                    .HasColumnType("money")
                    .HasColumnName("maxprice");

                entity.Property(e => e.Medianame)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("medianame")
                    .IsFixedLength();

                entity.Property(e => e.Medrate)
                    .HasColumnType("money")
                    .HasColumnName("medrate");

                entity.Property(e => e.Medrate2)
                    .HasColumnType("money")
                    .HasColumnName("medrate2");

                entity.Property(e => e.Medrate3)
                    .HasColumnType("money")
                    .HasColumnName("medrate3");

                entity.Property(e => e.Minprice)
                    .HasColumnType("money")
                    .HasColumnName("minprice");

                entity.Property(e => e.Osd)
                    .HasColumnType("datetime")
                    .HasColumnName("osd");

                entity.Property(e => e.Soldout).HasColumnName("soldout");
            });

            modelBuilder.Entity<Qmedium>(entity =>
            {
                entity.HasKey(e => e.Medianame);

                entity.ToTable("qmedia");

                entity.Property(e => e.Medianame)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("medianame")
                    .IsFixedLength();

                entity.Property(e => e.Admaxcols).HasColumnName("admaxcols");

                entity.Property(e => e.Admaxdepth)
                    .HasColumnType("numeric(6, 3)")
                    .HasColumnName("admaxdepth");

                entity.Property(e => e.Chksum4).HasColumnName("chksum4");

                entity.Property(e => e.Colsize)
                    .HasColumnType("numeric(6, 3)")
                    .HasColumnName("colsize");

                entity.Property(e => e.Createby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("createby")
                    .IsFixedLength();

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Defdimcol)
                    .HasColumnType("numeric(6, 3)")
                    .HasColumnName("defdimcol");

                entity.Property(e => e.Defdimrow)
                    .HasColumnType("numeric(6, 3)")
                    .HasColumnName("defdimrow");

                entity.Property(e => e.Deptname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("deptname");

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.Givetoint).HasColumnName("givetoint");

                entity.Property(e => e.Glcode)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("glcode");

                entity.Property(e => e.Internet).HasColumnName("internet");

                entity.Property(e => e.Lastrevby)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("lastrevby")
                    .IsFixedLength();

                entity.Property(e => e.Lastrevdat)
                    .HasColumnType("datetime")
                    .HasColumnName("lastrevdat");

                entity.Property(e => e.Mcolsize)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mcolsize")
                    .IsFixedLength();

                entity.Property(e => e.Mediagroup)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("mediagroup")
                    .IsFixedLength();

                entity.Property(e => e.Mediatype).HasColumnName("mediatype");

                entity.Property(e => e.Mrowsize)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mrowsize")
                    .IsFixedLength();

                entity.Property(e => e.Nocomiss).HasColumnName("nocomiss");

                entity.Property(e => e.Nonmedia).HasColumnName("nonmedia");

                entity.Property(e => e.Notsendtsh).HasColumnName("notsendtsh");

                entity.Property(e => e.Onlychoice).HasColumnName("onlychoice");

                entity.Property(e => e.Pagesize).HasColumnName("pagesize");

                entity.Property(e => e.Preset).HasColumnName("preset");

                entity.Property(e => e.Pubsubg).HasColumnName("pubsubg");

                entity.Property(e => e.Pubtype).HasColumnName("pubtype");

                entity.Property(e => e.Quickgroup)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("quickgroup")
                    .IsFixedLength();

                entity.Property(e => e.Quickname)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("quickname")
                    .IsFixedLength();

                entity.Property(e => e.Ted).HasColumnName("ted");
            });

            modelBuilder.Entity<Rcinote>(entity =>
            {
                entity.HasKey(e => e.Corpid);

                entity.ToTable("rcinotes");

                entity.Property(e => e.Corpid)
                    .ValueGeneratedNever()
                    .HasColumnName("corpid");

                entity.Property(e => e.RcinotesPad)
                    .HasColumnType("text")
                    .HasColumnName("notes_pad");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => new { e.Corpid, e.Userid });

                entity.ToTable("tags");

                entity.Property(e => e.Corpid).HasColumnName("corpid");

                entity.Property(e => e.Userid)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("userid");

                entity.Property(e => e.Tagcheck).HasColumnName("tagcheck");

                entity.Property(e => e.Tagdate)
                    .HasColumnType("datetime")
                    .HasColumnName("tagdate");

                entity.Property(e => e.Tagtype).HasColumnName("tagtype");

                entity.Property(e => e.Wavefile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wavefile");
            });

            modelBuilder.Entity<TblNb>(entity =>
            {
                entity.HasKey(e => e.Nbid);

                entity.ToTable("tblNB");

                entity.Property(e => e.Nbid).HasColumnName("NBID");

                entity.Property(e => e.Address).HasMaxLength(6);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.PhoneNumber).HasMaxLength(15);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(6)
                    .HasColumnName("PINCode");
            });

            modelBuilder.Entity<Visnote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("visnotes");

                entity.Property(e => e.Corpid).HasColumnName("corpid");

                entity.Property(e => e.VisnotesPad)
                    .HasColumnType("text")
                    .HasColumnName("notes_pad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
