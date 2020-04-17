using Microsoft.EntityFrameworkCore.Migrations;

namespace my_new_app.Migrations
{
    public partial class UpdateFK1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Banks_BankId1",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId1",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Users_UserId",
                table: "Spending_Details");

            migrationBuilder.DropIndex(
                name: "IX_Spending_Details_BankId1",
                table: "Spending_Details");

            migrationBuilder.DropIndex(
                name: "IX_Spending_Details_SpendingId1",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "BankId1",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "SpendingId1",
                table: "Spending_Details");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Spending_Details",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SpendingId",
                table: "Spending_Details",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Spending_Details",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpendingId",
                table: "Spending_Details",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BankId",
                table: "Spending_Details",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankId1",
                table: "Spending_Details",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpendingId1",
                table: "Spending_Details",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_BankId1",
                table: "Spending_Details",
                column: "BankId1");

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_SpendingId1",
                table: "Spending_Details",
                column: "SpendingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Banks_BankId1",
                table: "Spending_Details",
                column: "BankId1",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details",
                column: "SpendingId",
                principalTable: "Spendings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId1",
                table: "Spending_Details",
                column: "SpendingId1",
                principalTable: "Spendings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Users_UserId",
                table: "Spending_Details",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
