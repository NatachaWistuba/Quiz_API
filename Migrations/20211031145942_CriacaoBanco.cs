/*
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CriacaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pontuacao = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nquestao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespostaC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespostaF1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespostaF2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespostaF3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ponto = table.Column<int>(type: "int", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Connected",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JogadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connected", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Connected_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogadas_Questoes_QuestaoId",
                        column: x => x.QuestaoId,
                        principalTable: "Questoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Connected_JogadorId",
                table: "Connected",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadas_QuestaoId",
                table: "Jogadas",
                column: "QuestaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connected");

            migrationBuilder.DropTable(
                name: "Jogadas");

            migrationBuilder.DropTable(
                name: "Jogadores");

            migrationBuilder.DropTable(
                name: "Questoes");
        }
    }
}
*/
