using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigAddSta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Series_IdSerie",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Genre_GenreId",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Season_IdSeason",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Series",
                table: "Series");

            migrationBuilder.RenameTable(
                name: "Series",
                newName: "Serie");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Serie",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Series_IdSeason",
                table: "Serie",
                newName: "IX_Serie_IdSeason");

            migrationBuilder.RenameIndex(
                name: "IX_Series_GenreId",
                table: "Serie",
                newName: "IX_Serie_GenreId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Serie",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Serie",
                table: "Serie",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDAte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    IdSerie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Serie_IdSerie",
                        column: x => x.IdSerie,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IdSerie",
                table: "Comments",
                column: "IdSerie");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Serie_IdSerie",
                table: "Rentals",
                column: "IdSerie",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_Genre_GenreId",
                table: "Serie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_Season_IdSeason",
                table: "Serie",
                column: "IdSeason",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Serie_IdSerie",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_Genre_GenreId",
                table: "Serie");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_Season_IdSeason",
                table: "Serie");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Serie",
                table: "Serie");

            migrationBuilder.RenameTable(
                name: "Serie",
                newName: "Series");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Series",
                newName: "Rating");

            migrationBuilder.RenameIndex(
                name: "IX_Serie_IdSeason",
                table: "Series",
                newName: "IX_Series_IdSeason");

            migrationBuilder.RenameIndex(
                name: "IX_Serie_GenreId",
                table: "Series",
                newName: "IX_Series_GenreId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Series",
                table: "Series",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Series_IdSerie",
                table: "Rentals",
                column: "IdSerie",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Genre_GenreId",
                table: "Series",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Season_IdSeason",
                table: "Series",
                column: "IdSeason",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
