using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class deneme_mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
               name: "DenemeSutun",
               table: "AspNetUserRoles",
               nullable: false,
               defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
