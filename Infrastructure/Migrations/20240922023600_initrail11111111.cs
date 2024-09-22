using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initrail11111111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_Confirmations_ConfirmationId",
                table: "TrackRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_Payments_PaymentId",
                table: "TrackRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_Users_AuthorId",
                table: "TrackRecords");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_Confirmations_ConfirmationId",
                table: "TrackRecords",
                column: "ConfirmationId",
                principalTable: "Confirmations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_Payments_PaymentId",
                table: "TrackRecords",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_Users_AuthorId",
                table: "TrackRecords",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_Confirmations_ConfirmationId",
                table: "TrackRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_Payments_PaymentId",
                table: "TrackRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackRecords_Users_AuthorId",
                table: "TrackRecords");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_Confirmations_ConfirmationId",
                table: "TrackRecords",
                column: "ConfirmationId",
                principalTable: "Confirmations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_Payments_PaymentId",
                table: "TrackRecords",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackRecords_Users_AuthorId",
                table: "TrackRecords",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
