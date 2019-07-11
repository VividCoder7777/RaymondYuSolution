using Microsoft.EntityFrameworkCore.Migrations;

namespace RaymondYuSolution.Migrations
{
    public partial class changedpageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                table: "CMSContents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                table: "CMSContents",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
