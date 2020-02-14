using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop.Migrations
{
    public partial class fixrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Customers_CustomerID",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CustomerID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "varchar(10)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 13);

            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CarID",
                table: "Customers",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cars_CarID",
                table: "Customers",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cars_CarID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CarID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "varchar(10)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CustomerID",
                table: "Cars",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Customers_CustomerID",
                table: "Cars",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
