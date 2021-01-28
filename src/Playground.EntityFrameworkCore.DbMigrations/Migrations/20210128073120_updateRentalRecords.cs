using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Playground.Migrations
{
    public partial class updateRentalRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PaymentId",
                table: "AppRentalRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppRentalRecords_CustomerId",
                table: "AppRentalRecords",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRentalRecords_PaymentId",
                table: "AppRentalRecords",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppRentalRecords_AppCustomers_CustomerId",
                table: "AppRentalRecords",
                column: "CustomerId",
                principalTable: "AppCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRentalRecords_AppPayments_PaymentId",
                table: "AppRentalRecords",
                column: "PaymentId",
                principalTable: "AppPayments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppRentalRecords_AppCustomers_CustomerId",
                table: "AppRentalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRentalRecords_AppPayments_PaymentId",
                table: "AppRentalRecords");

            migrationBuilder.DropIndex(
                name: "IX_AppRentalRecords_CustomerId",
                table: "AppRentalRecords");

            migrationBuilder.DropIndex(
                name: "IX_AppRentalRecords_PaymentId",
                table: "AppRentalRecords");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "AppRentalRecords");
        }
    }
}
