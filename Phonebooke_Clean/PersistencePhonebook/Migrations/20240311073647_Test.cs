using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersistencePhonebook.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phonenumber",
                table: "Contacts",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Contacts",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Descriptaion",
                table: "Contacts",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Contacts",
                newName: "Phonenumber");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Contacts",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Contacts",
                newName: "Descriptaion");
        }
    }
}
