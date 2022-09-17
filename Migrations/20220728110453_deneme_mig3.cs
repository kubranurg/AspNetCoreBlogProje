using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class deneme_mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersID",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RolesID",
                table: "AspNetUserRoles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
