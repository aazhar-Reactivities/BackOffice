using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ListingsTrades.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acct_Id = table.Column<int>(type: "int", nullable: false),
                    GST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ends = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrokerAccount = table.Column<int>(type: "int", nullable: false),
                    AgentAccount = table.Column<int>(type: "int", nullable: false),
                    FeeAccount = table.Column<int>(type: "int", nullable: false),
                    TaxRate = table.Column<double>(type: "float", nullable: false),
                    TaxAccount = table.Column<int>(type: "int", nullable: false),
                    ChargeHOFees = table.Column<bool>(type: "bit", nullable: false),
                    AllowFeeDiscounting = table.Column<bool>(type: "bit", nullable: false),
                    ChargePST = table.Column<bool>(type: "bit", nullable: false),
                    PSTRate = table.Column<double>(type: "float", nullable: false),
                    CreditOffice = table.Column<int>(type: "int", nullable: false),
                    ListStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommissionPlan = table.Column<int>(type: "int", nullable: false),
                    BrokerAccount_S = table.Column<int>(type: "int", nullable: false),
                    AgentAccount_S = table.Column<int>(type: "int", nullable: false),
                    RevenueAccount_S = table.Column<int>(type: "int", nullable: false),
                    NotIn231 = table.Column<bool>(type: "bit", nullable: false),
                    InactiveDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report2HO = table.Column<bool>(type: "bit", nullable: false),
                    RentalType = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourceOfBusiness",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceOfBusiness", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "SourceOfBusiness");
        }
    }
}
