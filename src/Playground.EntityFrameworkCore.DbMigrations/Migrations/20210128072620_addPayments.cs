using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Playground.Migrations
{
    public partial class addPayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppCustomers",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppCustomers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPayments_AppCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AppCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppPayments_CustomerId",
                table: "AppPayments",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppPayments");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppCustomers");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppCustomers");
        }
    }
}
