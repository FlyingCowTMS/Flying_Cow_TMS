using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flying_Cow_TMS.Migrations
{
    public partial class Data001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Anomaly");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Abnormal");

            migrationBuilder.CreateTable(
                name: "Carrier_Profit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cp_Id = table.Column<int>(nullable: false),
                    cp_Profit = table.Column<float>(nullable: false),
                    cp_ElseCost = table.Column<float>(nullable: false),
                    cp_EndTime = table.Column<DateTime>(nullable: false),
                    cp_Aggregate = table.Column<float>(nullable: false),
                    ciid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier_Profit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consignee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    co_Id = table.Column<int>(nullable: false),
                    co_Company = table.Column<string>(nullable: true),
                    co_Person = table.Column<string>(nullable: true),
                    co_Phone = table.Column<string>(nullable: true),
                    co_Address = table.Column<string>(nullable: true),
                    eid = table.Column<int>(nullable: false),
                    co_State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dispatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dis_Id = table.Column<int>(nullable: false),
                    routeid = table.Column<int>(nullable: false),
                    transportid = table.Column<int>(nullable: false),
                    orderid = table.Column<int>(nullable: false),
                    dis_State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    d_Id = table.Column<int>(nullable: false),
                    ifid = table.Column<int>(nullable: false),
                    oid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Driver_Quotation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dq_Id = table.Column<int>(nullable: false),
                    ifid = table.Column<int>(nullable: false),
                    oid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver_Quotation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrust",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    e_Id = table.Column<int>(nullable: false),
                    e_Company = table.Column<string>(nullable: true),
                    e_Person = table.Column<string>(nullable: true),
                    e_Phone = table.Column<string>(nullable: true),
                    e_Address = table.Column<string>(nullable: true),
                    e_AddPerson = table.Column<string>(nullable: true),
                    e_AddPhone = table.Column<string>(nullable: true),
                    ifid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrust", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inquiry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    if_Id = table.Column<int>(nullable: false),
                    if_Number = table.Column<string>(nullable: true),
                    if_OrderTime = table.Column<DateTime>(nullable: false),
                    if_PlanBCarTime = table.Column<DateTime>(nullable: false),
                    if_PlanArrivalTime = table.Column<DateTime>(nullable: false),
                    if_BCarTime = table.Column<DateTime>(nullable: false),
                    if_BeginPlace = table.Column<string>(nullable: true),
                    if_EndPlace = table.Column<string>(nullable: true),
                    if_State = table.Column<int>(nullable: false),
                    if_Remark = table.Column<string>(nullable: true),
                    if_Specification = table.Column<string>(nullable: true),
                    if_TotalPackage = table.Column<string>(nullable: true),
                    if_Num = table.Column<int>(nullable: false),
                    if_AllWeight = table.Column<string>(nullable: true),
                    if_Goods = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jurisdiction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    juris_Id = table.Column<int>(nullable: false),
                    juris_MenuName = table.Column<string>(nullable: true),
                    juris_Pid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jurisdiction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    o_Id = table.Column<int>(nullable: false),
                    o_Driver = table.Column<string>(nullable: true),
                    o_Nature = table.Column<string>(nullable: true),
                    o_Row = table.Column<string>(nullable: true),
                    o_Type = table.Column<string>(nullable: true),
                    o_CarSpec = table.Column<string>(nullable: true),
                    o_State = table.Column<int>(nullable: false),
                    o_Price = table.Column<float>(nullable: false),
                    o_Capacity = table.Column<string>(nullable: true),
                    o_Starting = table.Column<string>(nullable: true),
                    o_Station = table.Column<string>(nullable: true),
                    o_Rated = table.Column<int>(nullable: false),
                    o_Freight = table.Column<float>(nullable: false),
                    o_Other = table.Column<float>(nullable: false),
                    o_TotalPrice = table.Column<float>(nullable: false),
                    ciid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    r_Id = table.Column<int>(nullable: false),
                    r_Order = table.Column<string>(nullable: true),
                    r_Article = table.Column<string>(nullable: true),
                    r_Spec = table.Column<string>(nullable: true),
                    r_Number = table.Column<int>(nullable: false),
                    r_Weight = table.Column<int>(nullable: false),
                    r_Volume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    role_Id = table.Column<int>(nullable: false),
                    role_Name = table.Column<string>(nullable: true),
                    role_Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleJurisdiction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    role_Id = table.Column<int>(nullable: false),
                    roleid = table.Column<int>(nullable: false),
                    jurisid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleJurisdiction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    r_Id = table.Column<int>(nullable: false),
                    r_Pass = table.Column<string>(nullable: true),
                    ifid = table.Column<int>(nullable: false),
                    r_Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Takegoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    t_Id = table.Column<int>(nullable: false),
                    t_Order = table.Column<string>(nullable: true),
                    t_Article = table.Column<string>(nullable: true),
                    t_Spec = table.Column<string>(nullable: true),
                    t_Number = table.Column<int>(nullable: false),
                    t_Weight = table.Column<float>(nullable: false),
                    t_Volume = table.Column<int>(nullable: false),
                    t_Starting = table.Column<string>(nullable: true),
                    t_Origin = table.Column<string>(nullable: true),
                    t_Station = table.Column<string>(nullable: true),
                    t_Address = table.Column<string>(nullable: true),
                    t_Picture = table.Column<string>(nullable: true),
                    t_Signing = table.Column<DateTime>(nullable: false),
                    oid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takegoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    user_Id = table.Column<int>(nullable: false),
                    user_Name = table.Column<string>(nullable: true),
                    user_Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    usro_Id = table.Column<int>(nullable: false),
                    userid = table.Column<int>(nullable: false),
                    roleid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrier_Profit");

            migrationBuilder.DropTable(
                name: "Consignee");

            migrationBuilder.DropTable(
                name: "Dispatch");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Driver_Quotation");

            migrationBuilder.DropTable(
                name: "Entrust");

            migrationBuilder.DropTable(
                name: "Inquiry");

            migrationBuilder.DropTable(
                name: "Jurisdiction");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleJurisdiction");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Takegoods");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Anomaly",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Address",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Abnormal",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
