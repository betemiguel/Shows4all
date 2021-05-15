using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigAddRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Rentals",
                newName: "Price");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Rentals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Rentals",
                newName: "TotalPrice");
        }
    }
}
