using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supply_chain_back.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSupplierdeQuotationFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuotationFile_Supplier_SupplierId",
                table: "QuotationFile");

            migrationBuilder.DropIndex(
                name: "IX_QuotationFile_SupplierId",
                table: "QuotationFile");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "QuotationFile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "QuotationFile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuotationFile_SupplierId",
                table: "QuotationFile",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationFile_Supplier_SupplierId",
                table: "QuotationFile",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
