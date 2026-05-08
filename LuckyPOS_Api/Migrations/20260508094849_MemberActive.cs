using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuckySystem_Api.Migrations
{
    /// <inheritdoc />
    public partial class MemberActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Member");
        }
    }
}
