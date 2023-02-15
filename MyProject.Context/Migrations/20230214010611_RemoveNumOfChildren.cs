using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    public partial class RemoveNumOfChildren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfChildren",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumOfChildren",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
