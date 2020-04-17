using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace my_new_app.Migrations
{
    public partial class UpdateFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Users_ApplicationUserId",
                table: "Spending_Details");

            migrationBuilder.DropIndex(
                name: "IX_Spending_Details_ApplicationUserId",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Spending_Details");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Spending_Details",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankId1",
                table: "Spending_Details",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpendingId1",
                table: "Spending_Details",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_BankId1",
                table: "Spending_Details",
                column: "BankId1");

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_SpendingId1",
                table: "Spending_Details",
                column: "SpendingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_UserId",
                table: "Spending_Details",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Banks_BankId1",
                table: "Spending_Details",
                column: "BankId1",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Banks_BankId1",
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

            migrationBuilder.DropIndex(
                name: "IX_Spending_Details_UserId",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "BankId1",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "SpendingId1",
                table: "Spending_Details");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Spending_Details",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Spending_Details",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_ApplicationUserId",
                table: "Spending_Details",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Users_ApplicationUserId",
                table: "Spending_Details",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
