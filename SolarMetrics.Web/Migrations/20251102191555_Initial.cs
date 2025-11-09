using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarMetrics.Web.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SM_USUARIO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(11)", maxLength: 11, nullable: true),
                    TipoUsuario = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USUARIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SM_SISTEMA",
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
                    table.PrimaryKey("PK_SM_SISTEMA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SM_SISTEMA_SM_USUARIO_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "SM_USUARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_PAINEL_SOLAR",
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
                    table.PrimaryKey("PK_SM_PAINEL_SOLAR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SM_PAINEL_SOLAR_SM_SISTEMA_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "SM_SISTEMA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_SENSOR",
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
                    table.PrimaryKey("PK_SM_SENSOR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SM_SENSOR_SM_SISTEMA_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "SM_SISTEMA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_MONITORAMENTO",
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
                    table.PrimaryKey("PK_SM_MONITORAMENTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SM_MONITORAMENTO_SM_SENSOR_SensorId",
                        column: x => x.SensorId,
                        principalTable: "SM_SENSOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SM_MONITORAMENTO_SensorId",
                table: "SM_MONITORAMENTO",
                column: "SensorId");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PAINEL_SOLAR_SistemaId",
                table: "SM_PAINEL_SOLAR",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SENSOR_SistemaId",
                table: "SM_SENSOR",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_SM_SISTEMA_ClienteId",
                table: "SM_SISTEMA",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USUARIO_Email",
                table: "SM_USUARIO",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SM_MONITORAMENTO");

            migrationBuilder.DropTable(
                name: "SM_PAINEL_SOLAR");

            migrationBuilder.DropTable(
                name: "SM_SENSOR");

            migrationBuilder.DropTable(
                name: "SM_SISTEMA");

            migrationBuilder.DropTable(
                name: "SM_USUARIO");
        }
    }
}
