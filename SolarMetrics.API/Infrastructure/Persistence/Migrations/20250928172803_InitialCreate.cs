using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarMetrics.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(11)", maxLength: 11, nullable: false),
                    TipoUsuario = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sistemas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NomeInstalacao = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    DataInstalacao = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    PotenciaTotal = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    ClienteId = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sistemas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaineisSolares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Modelo = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Fabricante = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    PotenciaMaxima = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataFabricacao = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Eficiencia = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SistemaId = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaineisSolares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaineisSolares_Sistemas_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "Sistemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sensores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Tipo = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Localizacao = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    SistemaId = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sensores_Sistemas_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "Sistemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monitoramentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Periodo = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    ValorLido = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MediaLeitura = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MaximaLeitura = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SensorId = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitoramentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitoramentos_Sensores_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Email",
                table: "Clientes",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monitoramentos_SensorId",
                table: "Monitoramentos",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_PaineisSolares_SistemaId",
                table: "PaineisSolares",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sensores_SistemaId",
                table: "Sensores",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sistemas_ClienteId",
                table: "Sistemas",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitoramentos");

            migrationBuilder.DropTable(
                name: "PaineisSolares");

            migrationBuilder.DropTable(
                name: "Sensores");

            migrationBuilder.DropTable(
                name: "Sistemas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
