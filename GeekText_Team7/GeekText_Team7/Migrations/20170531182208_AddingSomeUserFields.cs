using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeekText_Team7.Migrations
{
    public partial class AddingSomeUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "User");

            migrationBuilder.DropColumn(
                name: "City",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "User");

            migrationBuilder.DropColumn(
                name: "State",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "User");
        }
    }
}
