using Microsoft.EntityFrameworkCore.Migrations;

namespace Playground.Migrations
{
    public partial class updateCustomerUniqueEmailConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppCustomers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AppCustomers_Email",
                table: "AppCustomers",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppCustomers_Email",
                table: "AppCustomers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AppCustomers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
