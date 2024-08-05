using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkS2.Migrations
{
    /// <inheritdoc />
    public partial class inital8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepId",
                table: "Depatments",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Depatments",
                newName: "DepId");
        }
    }
}
