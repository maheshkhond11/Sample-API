using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class updatedstructure2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Phones_PhoneId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_PhoneId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "Sales");

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    FinalPrice = table.Column<double>(type: "float", nullable: false),
                    SoldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_Record_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Record_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "SaleId");
                    table.ForeignKey(
                        name: "FK_Record_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_Id",
                table: "Record",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Record_PhoneId",
                table: "Record",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Record_SaleId",
                table: "Record",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PhoneId",
                table: "Sales",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Phones_PhoneId",
                table: "Sales",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "PhoneId");
        }
    }
}
