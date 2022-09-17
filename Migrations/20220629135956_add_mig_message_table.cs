using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAcessLayer.Migrations
{
    public partial class add_mig_message_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(nullable: true),
                    Receiver = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    MessageDetails = table.Column<string>(nullable: true),
                    MessageDate = table.Column<DateTime>(nullable: false),
                    MessageStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
