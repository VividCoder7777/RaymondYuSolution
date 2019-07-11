using Microsoft.EntityFrameworkCore.Migrations;

namespace RaymondYuSolution.Migrations
{
    public partial class dsa3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "CMSContents",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CMSContents");
        }
    }
}
