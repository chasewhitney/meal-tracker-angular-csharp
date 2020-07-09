using Microsoft.EntityFrameworkCore.Migrations;

namespace MealTracker.API.Migrations
{
    public partial class CreatedGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MinCalories = table.Column<int>(nullable: true),
                    MaxCalories = table.Column<int>(nullable: true),
                    MinFat = table.Column<int>(nullable: true),
                    MaxFat = table.Column<int>(nullable: true),
                    MinProtein = table.Column<int>(nullable: true),
                    MaxProtein = table.Column<int>(nullable: true),
                    MinCarbs = table.Column<int>(nullable: true),
                    MaxCarbs = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId",
                table: "Goals",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");
        }
    }
}
