using Microsoft.EntityFrameworkCore.Migrations;

namespace MealTracker.API.Migrations
{
    public partial class AddedNetCarbsToMeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NetCarbs",
                table: "Meals",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetCarbs",
                table: "Meals");
        }
    }
}
