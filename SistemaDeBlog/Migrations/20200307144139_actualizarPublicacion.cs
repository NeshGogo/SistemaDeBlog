using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeBlog.Migrations
{
    public partial class actualizarPublicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Publicaciones",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Publicaciones");
        }
    }
}
