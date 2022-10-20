using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAQS.Web.Migrations
{
    public partial class AddCategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyContact",
                columns: table => new
                {
                    corpid = table.Column<int>(type: "int", nullable: false),
                    rowid = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    delrec = table.Column<bool>(type: "bit", nullable: false),
                    company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pharea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altpharea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altphext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altphtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pharea800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone800 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faxarea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlweb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    agcorpid = table.Column<int>(type: "int", nullable: false),
                    prvemp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skillset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lpcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactid2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parentid = table.Column<int>(type: "int", nullable: false),
                    persemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlcareers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyContact");
        }
    }
}
