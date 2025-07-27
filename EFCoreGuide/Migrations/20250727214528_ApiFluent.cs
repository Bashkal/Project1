using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreGuide.Migrations
{
    /// <inheritdoc />
    public partial class ApiFluent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Guides",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Guides_Brands_BrandId",
                table: "Guides",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guides_Brands_BrandId",
                table: "Guides");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Guides",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Guides_Brands_BrandId",
                table: "Guides",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }
    }
}
