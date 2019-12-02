using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.Persistence.Migrations
{
    public partial class UpdateOnlineStoreDomainRegionNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OnlineStoreDomainRegion",
                table: "Baskets",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OnlineStoreDomainRegion",
                table: "Baskets",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 55,
                oldNullable: true);
        }
    }
}
