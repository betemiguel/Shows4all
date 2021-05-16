using Microsoft.EntityFrameworkCore.Migrations;

namespace Shows4all.App.Migrations
{
    public partial class MigComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCustomer",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IdCustomer",
                table: "Comments",
                column: "IdCustomer");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Customers_IdCustomer",
                table: "Comments",
                column: "IdCustomer",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Customers_IdCustomer",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_IdCustomer",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IdCustomer",
                table: "Comments");
        }
    }
}
