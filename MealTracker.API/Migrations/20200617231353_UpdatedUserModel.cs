using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MealTracker.API.Migrations
{
    public partial class UpdatedUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<byte[]>(
                name: "SaltHash",
                table: "Users",
                type: "BLOB",
                nullable: true);
        }
    }
}
