using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace my_new_app.Migrations
{
    public partial class Spending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BankName = table.Column<string>(maxLength: 50, nullable: true),
                    RedMoney = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spendings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    Money = table.Column<int>(nullable: false),
                    revenue_and_expenditure = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spendings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spending_Detail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false),
                    SpendingId = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<int>(nullable: true),
                    UserRoleRoleId = table.Column<int>(nullable: true),
                    UserRoleUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spending_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spending_Detail_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spending_Detail_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spending_Detail_Spendings_SpendingId",
                        column: x => x.SpendingId,
                        principalTable: "Spendings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spending_Detail_UserRoles_UserRoleUserId_UserRoleRoleId",
                        columns: x => new { x.UserRoleUserId, x.UserRoleRoleId },
                        principalTable: "UserRoles",
                        principalColumns: new[] { "UserId", "RoleId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Detail_ApplicationUserId",
                table: "Spending_Detail",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Detail_BankId",
                table: "Spending_Detail",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Detail_SpendingId",
                table: "Spending_Detail",
                column: "SpendingId");

            migrationBuilder.CreateIndex(
                name: "IX_Spending_Detail_UserRoleUserId_UserRoleRoleId",
                table: "Spending_Detail",
                columns: new[] { "UserRoleUserId", "UserRoleRoleId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spending_Detail");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Spendings");
        }
    }
}
