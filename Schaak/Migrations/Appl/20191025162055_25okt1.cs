using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schaak.Migrations.Appl
{
    public partial class _25okt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contestent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TournementId = table.Column<int>(nullable: false),
                    UsersId = table.Column<string>(nullable: false),
                    EnlistDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contestent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    RegistrationStartDate = table.Column<DateTime>(nullable: true),
                    RegistrationEndDate = table.Column<DateTime>(nullable: true),
                    TournementStartDate = table.Column<DateTime>(nullable: false),
                    TournementEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournement", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contestent");

            migrationBuilder.DropTable(
                name: "Tournement");
        }
    }
}
