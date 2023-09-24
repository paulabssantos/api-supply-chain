using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supply_chain_back.Migrations
{
    /// <inheritdoc />
    public partial class removeCodedeQuotationeProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Quotation");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Quotation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
