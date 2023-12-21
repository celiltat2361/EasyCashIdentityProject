using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class new_customer_acc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesse_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesse_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAccountProcesse",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CustomerAccountProcesse");

            migrationBuilder.RenameTable(
                name: "CustomerAccountProcesse",
                newName: "CustomerAccountProcess");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesse_SenderID",
                table: "CustomerAccountProcess",
                newName: "IX_CustomerAccountProcess_SenderID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesse_ReceiverID",
                table: "CustomerAccountProcess",
                newName: "IX_CustomerAccountProcess_ReceiverID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAccountProcess",
                table: "CustomerAccountProcess",
                column: "CustomerAccountProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcess_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcess",
                column: "ReceiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcess_CustomerAccounts_SenderID",
                table: "CustomerAccountProcess",
                column: "SenderID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcess_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcess_CustomerAccounts_SenderID",
                table: "CustomerAccountProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAccountProcess",
                table: "CustomerAccountProcess");

            migrationBuilder.RenameTable(
                name: "CustomerAccountProcess",
                newName: "CustomerAccountProcesse");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcess_SenderID",
                table: "CustomerAccountProcesse",
                newName: "IX_CustomerAccountProcesse_SenderID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcess_ReceiverID",
                table: "CustomerAccountProcesse",
                newName: "IX_CustomerAccountProcesse_ReceiverID");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CustomerAccountProcesse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAccountProcesse",
                table: "CustomerAccountProcesse",
                column: "CustomerAccountProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesse_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesse",
                column: "ReceiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesse_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesse",
                column: "SenderID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }
    }
}
