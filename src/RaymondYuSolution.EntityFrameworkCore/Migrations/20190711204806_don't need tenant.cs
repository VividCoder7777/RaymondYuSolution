using Microsoft.EntityFrameworkCore.Migrations;

namespace RaymondYuSolution.Migrations
{
    public partial class dontneedtenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CMSContents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "CMSContents",
                nullable: false,
                defaultValue: 0);
        }
    }
}
