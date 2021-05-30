using Microsoft.EntityFrameworkCore.Migrations;

namespace CetToDoList.Data.Migrations
{
    public partial class vol6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "Catagories",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Catagories_CatagoryId",
                table: "Catagories",
                column: "CatagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catagories_Catagories_CatagoryId",
                table: "Catagories",
                column: "CatagoryId",
                principalTable: "Catagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catagories_Catagories_CatagoryId",
                table: "Catagories");

            migrationBuilder.DropIndex(
                name: "IX_Catagories_CatagoryId",
                table: "Catagories");

            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "Catagories");
        }
    }
}
