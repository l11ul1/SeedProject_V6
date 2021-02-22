using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeedProject_V6.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "seed_Product",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false),
                    vendorId = table.Column<int>(type: "int", nullable: true),
                    productName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                });

            migrationBuilder.CreateTable(
                name: "seed_ProductInfo",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    productPrice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    productImg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    productRating = table.Column<double>(type: "float", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "date", nullable: false),
                    ratingCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seed_Products", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seed_Product");

            migrationBuilder.DropTable(
                name: "seed_ProductInfo");
        }
    }
}
