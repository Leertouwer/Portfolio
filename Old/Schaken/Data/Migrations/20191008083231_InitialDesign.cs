using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schaken.Data.Migrations
{
    public partial class InitialDesign : Migration
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
                    AspNetUsersId = table.Column<int>(nullable: false),
                    EnlistTime = table.Column<DateTime>(nullable: false)
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
                    Name = table.Column<string>(nullable: true),
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
