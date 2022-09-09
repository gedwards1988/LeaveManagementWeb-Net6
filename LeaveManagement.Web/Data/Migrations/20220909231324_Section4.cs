using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class Section4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateJoined",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "LeaveAllocations");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "LeaveAllocations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "LeaveAllocations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "LeaveAllocations");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoined",
                table: "LeaveAllocations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "LeaveAllocations",
                type: "datetime2",
                nullable: true);
        }
    }
}
