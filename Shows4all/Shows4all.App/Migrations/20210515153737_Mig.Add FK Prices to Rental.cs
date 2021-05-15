using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigAddFKPricestoRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Serie_IdSerie",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_IdSerie",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "IdSerie",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Rentals",
                newName: "IdPriceSeries");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_IdPriceSeries",
                table: "Rentals",
                column: "IdPriceSeries");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_PricesSeries_IdPriceSeries",
                table: "Rentals",
                column: "IdPriceSeries",
                principalTable: "PricesSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_PricesSeries_IdPriceSeries",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_IdPriceSeries",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "IdPriceSeries",
                table: "Rentals",
                newName: "Quantity");

            migrationBuilder.AddColumn<int>(
                name: "IdSerie",
                table: "Rentals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Rentals",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_IdSerie",
                table: "Rentals",
                column: "IdSerie");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Serie_IdSerie",
                table: "Rentals",
                column: "IdSerie",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
