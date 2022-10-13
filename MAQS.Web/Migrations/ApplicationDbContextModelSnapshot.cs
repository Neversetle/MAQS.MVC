﻿// <auto-generated />
using System;
using MAQS.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MAQS.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MAQS.Web.Models.CompanyContact", b =>
                {
                    b.Property<string>("address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("agcorpid")
                        .HasColumnType("int");

                    b.Property<string>("altpharea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("altphext")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("altphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("altphtype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactid2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("corpid")
                        .HasColumnType("int");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("createdby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("delrec")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faxarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lpcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parentid")
                        .HasColumnType("int");

                    b.Property<string>("persemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pharea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pharea800")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phext")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone800")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phtype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prvemp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rowid")
                        .HasColumnType("int");

                    b.Property<string>("skillset")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("updatedby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlcareers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlweb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CompanyContact");
                });
#pragma warning restore 612, 618
        }
    }
}
