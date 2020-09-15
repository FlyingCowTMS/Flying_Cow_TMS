using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flying_Cow_TMS.Migrations
{
    public partial class AddTow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    a_Id = table.Column<int>(nullable: false),
                    a_Time = table.Column<DateTime>(nullable: false),
                    a_Site = table.Column<string>(nullable: true),
                    ifid = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anomaly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ano_Id = table.Column<int>(nullable: false),
                    aid = table.Column<int>(nullable: false),
                    ano_processing = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anomaly", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Anomaly");
        }
    }
}
