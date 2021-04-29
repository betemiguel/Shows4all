using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigAddRemoveSerie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "Series",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Series_SerieId",
                table: "Series",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Series_SerieId",
                table: "Series",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Series_SerieId",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Series_SerieId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "Series");
        }
    }
}
