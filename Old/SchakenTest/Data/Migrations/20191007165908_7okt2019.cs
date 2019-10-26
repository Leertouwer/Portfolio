using Microsoft.EntityFrameworkCore.Migrations;

namespace Schaken.Data.Migrations
{
    public partial class _7okt2019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tournement",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tournement",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
