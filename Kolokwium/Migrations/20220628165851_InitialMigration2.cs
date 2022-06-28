using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberID", "MemberName", "MemberNickName", "MemberSurname", "OrganizationID" },
                values: new object[] { 1, "Andrzej", "AndrzejKowalski", "Kowalski", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberID", "MemberName", "MemberNickName", "MemberSurname", "OrganizationID" },
                values: new object[] { 3, "Andrzej", "AndrzejKowalski", "Kowalski", 0 });
        }
    }
}
