using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LambdaForums.Migrations
{
    public partial class UpdateApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MemberSince",
                table: "ApplicationUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "ApplicationUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "ApplicationUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "ApplicationUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberSince",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "ApplicationUsers");
        }
    }
}
