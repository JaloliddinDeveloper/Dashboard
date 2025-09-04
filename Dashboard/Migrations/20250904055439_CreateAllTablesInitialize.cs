using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class CreateAllTablesInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Education = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Healthcare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Defense = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Infrastructure = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Other = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyRateDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UsdToUzs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EurToUzs = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRateDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DemographyDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false),
                    UrbanPercent = table.Column<double>(type: "float", nullable: false),
                    RuralPercent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemographyDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GdpDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GdpDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InflationDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InflationDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectorDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Agriculture = table.Column<double>(type: "float", nullable: false),
                    Industry = table.Column<double>(type: "float", nullable: false),
                    Services = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Export = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Import = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnemploymentDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnemploymentDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetDatas");

            migrationBuilder.DropTable(
                name: "CurrencyRateDatas");

            migrationBuilder.DropTable(
                name: "DemographyDatas");

            migrationBuilder.DropTable(
                name: "GdpDatas");

            migrationBuilder.DropTable(
                name: "InflationDatas");

            migrationBuilder.DropTable(
                name: "SectorDatas");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TradeDatas");

            migrationBuilder.DropTable(
                name: "UnemploymentDatas");
        }
    }
}
