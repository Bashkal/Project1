using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class Guides : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "Guides",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Guides_DepartmentId",
                table: "Guides",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guides_Departments_DepartmentId",
                table: "Guides",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guides_Departments_DepartmentId",
                table: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_Guides_DepartmentId",
                table: "Guides");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentId",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
