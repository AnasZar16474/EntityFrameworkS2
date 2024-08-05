using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkS2.Migrations
{
    /// <inheritdoc />
    public partial class inital7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Depatments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Depatments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
