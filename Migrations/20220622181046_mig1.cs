using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(nullable: true),
                    AboutDetails2 = table.Column<string>(nullable: true),
                    AboutImage1 = table.Column<string>(nullable: true),
                    AboutImage2 = table.Column<string>(nullable: true),
                    AboutMapLocation = table.Column<string>(nullable: true),
                    AboutStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(nullable: true),
                    BlogContent = table.Column<string>(nullable: true),
                    BlogThumnailImage = table.Column<string>(nullable: true),
                    BlogImage = table.Column<string>(nullable: true),
                    BlogCreateDate = table.Column<DateTime>(nullable: false),
                    BlogStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true),
                    CategoryStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(nullable: true),
                    CommentTitle = table.Column<string>(nullable: true),
                    CommentContent = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    CommentStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUserName = table.Column<string>(nullable: true),
                    ContactMail = table.Column<string>(nullable: true),
                    ContactSubject = table.Column<string>(nullable: true),
                    ContactMessage = table.Column<string>(nullable: true),
                    ContactDate = table.Column<DateTime>(nullable: false),
                    ContactStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(nullable: true),
                    WriterAbout = table.Column<string>(nullable: true),
                    WriterImage = table.Column<string>(nullable: true),
                    WriterMail = table.Column<string>(nullable: true),
                    WriterPassword = table.Column<string>(nullable: true),
                    WriterStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
