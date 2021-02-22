using Microsoft.EntityFrameworkCore.Migrations;

namespace Robotopia.Migrations
{
    public partial class things : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentCUPPowerPoints",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCUPPowerPoints",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCUPPowerPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalCUPPowerPoints",
                table: "AspNetUsers");
        }
    }
}
