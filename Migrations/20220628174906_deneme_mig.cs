using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class deneme_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
            name: "BlogScore",
            table: "Comments",
            nullable: false,
            defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
