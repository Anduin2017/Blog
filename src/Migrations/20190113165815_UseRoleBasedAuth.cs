using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiursoft.Blog.Migrations
{
    public partial class UseRoleBasedAuth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWebSiteOwner",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWebSiteOwner",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }
    }
}
