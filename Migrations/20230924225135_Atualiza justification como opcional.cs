using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supply_chain_back.Migrations
{
    /// <inheritdoc />
    public partial class Atualizajustificationcomoopcional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Justification",
                table: "PurchaseOrder",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PurchaseOrder",
                keyColumn: "Justification",
                keyValue: null,
                column: "Justification",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Justification",
                table: "PurchaseOrder",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
