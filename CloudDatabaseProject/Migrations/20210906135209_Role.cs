using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudDatabaseProject.Migrations
{
    public partial class Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Customers_CustomerId",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Invoice",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_CustomerId",
                table: "Invoice",
                newName: "IX_Invoice_CustomerID");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Invoice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Customers_CustomerID",
                table: "Invoice",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Customers_CustomerID",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Invoice",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_CustomerID",
                table: "Invoice",
                newName: "IX_Invoice_CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Customers_CustomerId",
                table: "Invoice",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
