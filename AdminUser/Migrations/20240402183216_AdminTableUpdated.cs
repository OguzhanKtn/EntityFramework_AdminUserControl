using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminUser.Migrations
{
    /// <inheritdoc />
    public partial class AdminTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AdminUsers",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AdminUsers",
                newName: "Name");
        }
    }
}
