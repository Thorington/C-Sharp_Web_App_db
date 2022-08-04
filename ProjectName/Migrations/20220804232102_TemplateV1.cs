using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectName.Migrations
{
    public partial class TemplateV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialty",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Specialty",
                table: "Categories",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
