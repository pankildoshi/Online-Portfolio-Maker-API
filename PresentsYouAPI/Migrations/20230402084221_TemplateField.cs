using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresentsYouAPI.Migrations
{
    /// <inheritdoc />
    public partial class TemplateField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Template",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Template",
                table: "Profiles");
        }
    }
}
