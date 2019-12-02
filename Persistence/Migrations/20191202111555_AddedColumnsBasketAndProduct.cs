using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Persistence.Migrations
{
    public partial class AddedColumnsBasketAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Buyer",
                table: "Baskets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OnlineStoreDomainRegion",
                table: "Baskets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Buyer",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "OnlineStoreDomainRegion",
                table: "Baskets");
        }
    }
}
