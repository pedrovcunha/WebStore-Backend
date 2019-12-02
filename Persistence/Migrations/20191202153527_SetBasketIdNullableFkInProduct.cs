using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Persistence.Migrations
{
    public partial class SetBasketIdNullableFkInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<Guid>(
                name: "BasketId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Category", "Description", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("89f811c6-e431-479f-829a-58848a5b5c61"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Liquor", "Cabernet Sauvignon", "RedWine A", 35.22m },
                    { new Guid("0bf3112b-9aad-4eed-a867-6f866fbb1900"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Liquor", "Shiraz", "Red Wine B", 22.0m },
                    { new Guid("289fa3ae-49de-4e5c-ae2b-56205f877965"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Liquor", "Cabernet Sauvignon", "Red Wine C", 15.3m },
                    { new Guid("11b6e96d-5fd5-4bbb-9b9b-40ab0057c820"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Liquor", "Pinot Noir", "Red Wine D", 45.5m },
                    { new Guid("5f6a20b9-b371-434b-99df-3a90907afeb1"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "Liquor", "Pinot Noir", "Red Wine E", 33.1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0bf3112b-9aad-4eed-a867-6f866fbb1900"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11b6e96d-5fd5-4bbb-9b9b-40ab0057c820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("289fa3ae-49de-4e5c-ae2b-56205f877965"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f6a20b9-b371-434b-99df-3a90907afeb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89f811c6-e431-479f-829a-58848a5b5c61"));

            migrationBuilder.AlterColumn<Guid>(
                name: "BasketId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

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
    }
}
