using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class seedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo hogar" },
                    { "HGR", "Hogar" },
                    { "PRF", "Permufería" },
                    { "VDJ", "Video juegos" }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[,]
                {
                    { "a1053c71-1cd7-427a-a043-394d824b9814", "Avenida siempre viva", "Bodega central" },
                    { "6f6f562b-855d-440a-a9f9-8f868ed38032", "Avenida siempre viva sur", "Bodega sur" },
                    { "e76c65ce-6f9d-499d-89d9-218ebd1a6761", "Avenida siempre viva norte", "Bodega norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "6f6f562b-855d-440a-a9f9-8f868ed38032");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "a1053c71-1cd7-427a-a043-394d824b9814");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "e76c65ce-6f9d-499d-89d9-218ebd1a6761");
        }
    }
}
