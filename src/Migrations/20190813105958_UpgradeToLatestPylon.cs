using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiursoft.Blog.Migrations
{
    public partial class UpgradeToLatestPylon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconFilePath",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconFilePath",
                table: "AspNetUsers");
        }
    }
}
