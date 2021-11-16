using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.Admin.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brief",
                table: "Sector",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "Char(50)", maxLength: 50, nullable: false),
                    StockExchange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerShare = table.Column<float>(type: "real", nullable: false),
                    NoOfShares = table.Column<long>(type: "bigint", nullable: false),
                    OpenDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ipo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ipo");

            migrationBuilder.DropColumn(
                name: "Brief",
                table: "Sector");
        }
    }
}
