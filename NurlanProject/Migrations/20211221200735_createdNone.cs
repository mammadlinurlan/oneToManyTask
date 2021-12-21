using Microsoft.EntityFrameworkCore.Migrations;

namespace NurlanProject.Migrations
{
    public partial class createdNone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
