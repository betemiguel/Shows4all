using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigAddNewtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Actor_IdActor",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Customers_IdCustomer",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Series_SerieId",
                table: "Series");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Series_IdActor",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Series_SerieId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "IdActor",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Season");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Season");

            migrationBuilder.RenameColumn(
                name: "IdCustomer",
                table: "Series",
                newName: "IdAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_Series_IdCustomer",
                table: "Series",
                newName: "IX_Series_IdAdmin");

            migrationBuilder.AddColumn<int>(
                name: "IdEpisode",
                table: "Season",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonNumber",
                table: "Season",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRental",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpisodeNumber = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    DateRented = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSerie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rental_Series_IdSerie",
                        column: x => x.IdSerie,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Season_IdEpisode",
                table: "Season",
                column: "IdEpisode");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdRental",
                table: "Customers",
                column: "IdRental");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_IdSerie",
                table: "Rental",
                column: "IdSerie");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rental_IdRental",
                table: "Customers",
                column: "IdRental",
                principalTable: "Rental",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Season_Episode_IdEpisode",
                table: "Season",
                column: "IdEpisode",
                principalTable: "Episode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Admins_IdAdmin",
                table: "Series",
                column: "IdAdmin",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rental_IdRental",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Season_Episode_IdEpisode",
                table: "Season");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Admins_IdAdmin",
                table: "Series");

            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.DropIndex(
                name: "IX_Season_IdEpisode",
                table: "Season");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdRental",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IdEpisode",
                table: "Season");

            migrationBuilder.DropColumn(
                name: "SeasonNumber",
                table: "Season");

            migrationBuilder.DropColumn(
                name: "IdRental",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "IdAdmin",
                table: "Series",
                newName: "IdCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_Series_IdAdmin",
                table: "Series",
                newName: "IX_Series_IdCustomer");

            migrationBuilder.AddColumn<int>(
                name: "IdActor",
                table: "Series",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "Series",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Season",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Season",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Series_IdActor",
                table: "Series",
                column: "IdActor");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SerieId",
                table: "Series",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Actor_IdActor",
                table: "Series",
                column: "IdActor",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Customers_IdCustomer",
                table: "Series",
                column: "IdCustomer",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Series_SerieId",
                table: "Series",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
