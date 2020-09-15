using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flying_Cow_TMS.Migrations
{
    public partial class addAbnormal1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abnormal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    a_Id = table.Column<int>(nullable: false),
                    a_Abnormal = table.Column<int>(nullable: false),
                    a_Explain = table.Column<string>(nullable: true),
                    a_Signer = table.Column<string>(nullable: true),
                    a_Signing = table.Column<DateTime>(nullable: false),
                    a_Status = table.Column<string>(nullable: true),
                    a_Picture = table.Column<string>(nullable: true),
                    a_Remarks = table.Column<string>(nullable: true),
                    receiptid = table.Column<string>(nullable: true),
                    ifid = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abnormal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abnormal");
        }
    }
}
