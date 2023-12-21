using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_customer_relation_process : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "CustomerAccountProcesse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "CustomerAccountProcesse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesse_ReceiverID",
                table: "CustomerAccountProcesse",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesse_SenderID",
                table: "CustomerAccountProcesse",
                column: "SenderID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesse_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesse_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesse_ReceiverID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesse_SenderID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "CustomerAccountProcesse");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "CustomerAccountProcesse");
        }
    }
}
