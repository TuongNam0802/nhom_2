using Microsoft.EntityFrameworkCore.Migrations;

namespace my_new_app.Migrations
{
    public partial class fix_key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Users_UserId",
                table: "Spending_Details");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Spending_Details",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpendingId",
                table: "Spending_Details",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Spending_Details",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details",
                column: "SpendingId",
                principalTable: "Spendings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Users_UserId",
                table: "Spending_Details",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Users_UserId",
                table: "Spending_Details");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Spending_Details",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SpendingId",
                table: "Spending_Details",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Spending_Details",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details",
                column: "SpendingId",
                principalTable: "Spendings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Users_UserId",
                table: "Spending_Details",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
