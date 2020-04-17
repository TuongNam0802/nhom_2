using Microsoft.EntityFrameworkCore.Migrations;

namespace my_new_app.Migrations
{
    public partial class updateBanks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Detail_Users_ApplicationUserId",
                table: "Spending_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Detail_Bank_BankId",
                table: "Spending_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Detail_Spendings_SpendingId",
                table: "Spending_Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Detail_UserRoles_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spending_Detail",
                table: "Spending_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bank",
                table: "Bank");

            migrationBuilder.RenameTable(
                name: "Spending_Detail",
                newName: "Spending_Details");

            migrationBuilder.RenameTable(
                name: "Bank",
                newName: "Banks");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Detail_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details",
                newName: "IX_Spending_Details_UserRoleUserId_UserRoleRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Detail_SpendingId",
                table: "Spending_Details",
                newName: "IX_Spending_Details_SpendingId");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Detail_BankId",
                table: "Spending_Details",
                newName: "IX_Spending_Details_BankId");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Detail_ApplicationUserId",
                table: "Spending_Details",
                newName: "IX_Spending_Details_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spending_Details",
                table: "Spending_Details",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banks",
                table: "Banks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Details_Users_ApplicationUserId",
                table: "Spending_Details",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Spending_Details_UserRoles_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" },
                principalTable: "UserRoles",
                principalColumns: new[] { "UserId", "RoleId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Users_ApplicationUserId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Banks_BankId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_Spendings_SpendingId",
                table: "Spending_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Spending_Details_UserRoles_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spending_Details",
                table: "Spending_Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banks",
                table: "Banks");

            migrationBuilder.RenameTable(
                name: "Spending_Details",
                newName: "Spending_Detail");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Bank");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Details_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Detail",
                newName: "IX_Spending_Detail_UserRoleUserId_UserRoleRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Details_SpendingId",
                table: "Spending_Detail",
                newName: "IX_Spending_Detail_SpendingId");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Details_BankId",
                table: "Spending_Detail",
                newName: "IX_Spending_Detail_BankId");

            migrationBuilder.RenameIndex(
                name: "IX_Spending_Details_ApplicationUserId",
                table: "Spending_Detail",
                newName: "IX_Spending_Detail_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spending_Detail",
                table: "Spending_Detail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bank",
                table: "Bank",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Detail_Users_ApplicationUserId",
                table: "Spending_Detail",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Detail_Bank_BankId",
                table: "Spending_Detail",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Detail_Spendings_SpendingId",
                table: "Spending_Detail",
                column: "SpendingId",
                principalTable: "Spendings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spending_Detail_UserRoles_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Detail",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" },
                principalTable: "UserRoles",
                principalColumns: new[] { "UserId", "RoleId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
