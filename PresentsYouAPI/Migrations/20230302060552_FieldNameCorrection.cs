using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresentsYouAPI.Migrations
{
    /// <inheritdoc />
    public partial class FieldNameCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComapnyName",
                table: "Experiences",
                newName: "CompanyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Experiences",
                newName: "ComapnyName");
        }
    }
}
