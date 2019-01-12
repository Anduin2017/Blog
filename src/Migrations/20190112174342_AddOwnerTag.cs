using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiursoft.Blog.Migrations
{
    public partial class AddOwnerTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWebSiteOwner",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWebSiteOwner",
                table: "AspNetUsers");
        }
    }
}
