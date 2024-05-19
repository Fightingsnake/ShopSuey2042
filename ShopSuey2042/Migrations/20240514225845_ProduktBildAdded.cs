using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopSuey2042.Migrations
{
    /// <inheritdoc />
    public partial class ProduktBildAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
