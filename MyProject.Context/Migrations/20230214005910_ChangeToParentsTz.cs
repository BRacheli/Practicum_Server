using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    public partial class ChangeToParentsTz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parent_1_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Parent_2_id",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Parent_1_tz",
                table: "Users",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Parent_2_tz",
                table: "Users",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parent_1_tz",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Parent_2_tz",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Parent_1_id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parent_2_id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
