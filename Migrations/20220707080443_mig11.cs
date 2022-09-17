using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
   name: "FK_Blogs_Categories_CategoryID",
   table: "Blogs",
   column: "CategoryID",
   principalTable: "Categories",
   principalColumn: "CategoryID",
   onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
