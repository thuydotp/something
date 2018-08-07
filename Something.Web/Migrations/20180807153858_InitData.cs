using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Something.Web.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    MainContent = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropTable(
                name: "PostModel");
        }
    }
}
