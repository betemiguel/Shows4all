using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigAddFKSerietoRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "IdSeries");

            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "Rentals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_SerieId",
                table: "Rentals",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Serie_SerieId",
                table: "Rentals",
                column: "SerieId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Serie_SerieId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_SerieId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "IdSeries",
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
    }
}
