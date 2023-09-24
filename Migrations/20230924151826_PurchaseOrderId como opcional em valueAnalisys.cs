using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supply_chain_back.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseOrderIdcomoopcionalemvalueAnalisys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ValueAnalisys_PurchaseOrder_PurchaseOrderId",
                table: "ValueAnalisys");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "ValueAnalisys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ValueAnalisys_PurchaseOrder_PurchaseOrderId",
                table: "ValueAnalisys",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ValueAnalisys_PurchaseOrder_PurchaseOrderId",
                table: "ValueAnalisys");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "ValueAnalisys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueAnalisys_PurchaseOrder_PurchaseOrderId",
                table: "ValueAnalisys",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
