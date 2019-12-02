using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Persistence.Migrations
{
    public partial class MappingSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "Buyer", "OnlineStoreDomainRegion" },
                values: new object[] { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Pedro", "Australia" });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "Buyer", "OnlineStoreDomainRegion" },
                values: new object[] { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "David", "Europe" });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "Buyer", "OnlineStoreDomainRegion" },
                values: new object[] { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "Stuart", "US" });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "Buyer", "OnlineStoreDomainRegion" },
                values: new object[] { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), "Frances", "Europe" });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "Buyer", "OnlineStoreDomainRegion" },
                values: new object[] { new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"), "Lin", "Us" });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "Buyer", "OnlineStoreDomainRegion" },
                values: new object[] { new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"), "Meghan", "Europe" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Category", "Description", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("f9b58d9c-ec75-4763-b8ee-1af45d3ad634"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Liquor", "Cabernet Sauvignon", "RedWine A", 35.22m },
                    { new Guid("02d0ddea-d910-4e3e-aa2d-ff26393e4ba3"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Liquor", "Shiraz", "Red Wine B", 22.0m },
                    { new Guid("844f8afb-53b9-4a03-877c-81ca56b8aff6"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Liquor", "Cabernet Sauvignon", "Red Wine C", 15.3m },
                    { new Guid("bfc15e18-553e-492d-881b-3034bad8ef23"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Liquor", "Pinot Noir", "Red Wine D", 45.5m },
                    { new Guid("f1c14ea7-7788-4a56-9b1c-a178bdc926ee"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Liquor", "Pinot Noir", "Red Wine E", 33.1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02d0ddea-d910-4e3e-aa2d-ff26393e4ba3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("844f8afb-53b9-4a03-877c-81ca56b8aff6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfc15e18-553e-492d-881b-3034bad8ef23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1c14ea7-7788-4a56-9b1c-a178bdc926ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9b58d9c-ec75-4763-b8ee-1af45d3ad634"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
