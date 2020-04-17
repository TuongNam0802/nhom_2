using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace my_new_app.Migrations
{
    public partial class A1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_UserRoles_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details");

            migrationBuilder.DropIndex(
                name: "IX_Spending_Details_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "UserRoleRoleId",
                table: "Spending_Details");

            migrationBuilder.DropColumn(
                name: "UserRoleUserId",
                table: "Spending_Details");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Spendings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Spendings");

            migrationBuilder.AddColumn<int>(
                name: "UserRoleRoleId",
                table: "Spending_Details",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRoleUserId",
                table: "Spending_Details",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Details_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_UserRoles_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" },
                principalTable: "UserRoles",
                principalColumns: new[] { "UserId", "RoleId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
