using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyTracker.Data.Migrations
{
    public partial class AddedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PropertyId",
                table: "People",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Buildings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_People_PropertyId",
                table: "People",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Properties_PropertyId",
                table: "People",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Properties_PropertyId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_PropertyId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Buildings");
        }
    }
}
