using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyTracker.Data.Migrations
{
    public partial class ModifiedRenovation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PropertyId",
                table: "Renovations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Renovations");
        }
    }
}
