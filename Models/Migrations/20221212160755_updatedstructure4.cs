using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class updatedstructure4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Record_Phones_PhoneId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Sales_SaleId",
                table: "Record");

            migrationBuilder.DropForeignKey(
                name: "FK_Record_Users_Id",
                table: "Record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Record",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "PhoneDiscount",
                table: "Phones");

            migrationBuilder.RenameTable(
                name: "Record",
                newName: "Records");

            migrationBuilder.RenameIndex(
                name: "IX_Record_SaleId",
                table: "Records",
                newName: "IX_Records_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_PhoneId",
                table: "Records",
                newName: "IX_Records_PhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Record_Id",
                table: "Records",
                newName: "IX_Records_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                column: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Phones_PhoneId",
                table: "Records",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "PhoneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Sales_SaleId",
                table: "Records",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Users_Id",
                table: "Records",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Phones_PhoneId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Sales_SaleId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Users_Id",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "Record");

            migrationBuilder.RenameIndex(
                name: "IX_Records_SaleId",
                table: "Record",
                newName: "IX_Record_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_PhoneId",
                table: "Record",
                newName: "IX_Record_PhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_Id",
                table: "Record",
                newName: "IX_Record_Id");

            migrationBuilder.AddColumn<double>(
                name: "PhoneDiscount",
                table: "Phones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Record",
                table: "Record",
                column: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Phones_PhoneId",
                table: "Record",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "PhoneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Sales_SaleId",
                table: "Record",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Users_Id",
                table: "Record",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
