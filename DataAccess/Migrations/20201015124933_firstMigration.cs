using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    WareHouseId = table.Column<string>(maxLength: 50, nullable: false),
                    WareHouseName = table.Column<string>(maxLength: 100, nullable: false),
                    WareHouseAddress = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.WareHouseId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 600, nullable: true),
                    TotalQuantity = table.Column<int>(nullable: false),
                    CategoryId = table.Column<string>(nullable: true),
                    CategoryEntityCategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryEntityCategoryId",
                        column: x => x.CategoryEntityCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StorageId = table.Column<int>(maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    PartialQuantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    ProductEntityProductId = table.Column<string>(nullable: true),
                    WareHouseId = table.Column<string>(nullable: true),
                    WareHouseEntityWareHouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_Storages_Products_ProductEntityProductId",
                        column: x => x.ProductEntityProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Storages_WareHouses_WareHouseEntityWareHouseId",
                        column: x => x.WareHouseEntityWareHouseId,
                        principalTable: "WareHouses",
                        principalColumn: "WareHouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InOuts",
                columns: table => new
                {
                    InOutId = table.Column<string>(maxLength: 50, nullable: false),
                    InOutDate = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IsInput = table.Column<int>(nullable: false),
                    StorageId = table.Column<string>(nullable: true),
                    StorageId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOuts", x => x.InOutId);
                    table.ForeignKey(
                        name: "FK_InOuts_Storages_StorageId1",
                        column: x => x.StorageId1,
                        principalTable: "Storages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_StorageId1",
                table: "InOuts",
                column: "StorageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryEntityCategoryId",
                table: "Products",
                column: "CategoryEntityCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ProductEntityProductId",
                table: "Storages",
                column: "ProductEntityProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WareHouseEntityWareHouseId",
                table: "Storages",
                column: "WareHouseEntityWareHouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InOuts");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WareHouses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
