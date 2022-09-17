using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig_add_blograyting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogRayting",
                columns: table => new
                {
                    BlogRaytingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogID = table.Column<int>(nullable: false),
                    BlogTotalScore = table.Column<int>(nullable: false),
                    BlogRaytingCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRayting", x => x.BlogRaytingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogRayting");
        }
    }
}
