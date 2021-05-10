using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigRemovePricefromSeason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Season");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Season",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
