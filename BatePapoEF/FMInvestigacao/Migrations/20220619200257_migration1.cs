using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMInvestigacao.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vilao",
                columns: table => new
                {
                    idVilao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    numCrime = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vilao", x => x.idVilao);
                });

            migrationBuilder.CreateTable(
                name: "Crime",
                columns: table => new
                {
                    idCrime = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: false),
                    local = table.Column<string>(type: "VARCHAR(45)", maxLength: 45, nullable: true),
                    duracao = table.Column<int>(type: "INT", nullable: false),
                    VilaoidVilao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crime", x => x.idCrime);
                    table.ForeignKey(
                        name: "FK_Vilao_Crime",
                        column: x => x.VilaoidVilao,
                        principalTable: "Vilao",
                        principalColumn: "idVilao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crime_VilaoidVilao",
                table: "Crime",
                column: "VilaoidVilao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crime");

            migrationBuilder.DropTable(
                name: "Vilao");
        }
    }
}
