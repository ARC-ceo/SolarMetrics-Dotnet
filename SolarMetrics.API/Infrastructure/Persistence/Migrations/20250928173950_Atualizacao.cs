using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarMetrics.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitoramentos_Sensores_SensorId",
                table: "Monitoramentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PaineisSolares_Sistemas_SistemaId",
                table: "PaineisSolares");

            migrationBuilder.DropForeignKey(
                name: "FK_Sensores_Sistemas_SistemaId",
                table: "Sensores");

            migrationBuilder.DropForeignKey(
                name: "FK_Sistemas_Clientes_ClienteId",
                table: "Sistemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sistemas",
                table: "Sistemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sensores",
                table: "Sensores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaineisSolares",
                table: "PaineisSolares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monitoramentos",
                table: "Monitoramentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Sistemas",
                newName: "SM_SISTEMA");

            migrationBuilder.RenameTable(
                name: "Sensores",
                newName: "SM_SENSOR");

            migrationBuilder.RenameTable(
                name: "PaineisSolares",
                newName: "SM_PAINEL_SOLAR");

            migrationBuilder.RenameTable(
                name: "Monitoramentos",
                newName: "SM_MONITORAMENTO");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "SM_USUARIO");

            migrationBuilder.RenameIndex(
                name: "IX_Sistemas_ClienteId",
                table: "SM_SISTEMA",
                newName: "IX_SM_SISTEMA_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Sensores_SistemaId",
                table: "SM_SENSOR",
                newName: "IX_SM_SENSOR_SistemaId");

            migrationBuilder.RenameIndex(
                name: "IX_PaineisSolares_SistemaId",
                table: "SM_PAINEL_SOLAR",
                newName: "IX_SM_PAINEL_SOLAR_SistemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Monitoramentos_SensorId",
                table: "SM_MONITORAMENTO",
                newName: "IX_SM_MONITORAMENTO_SensorId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_Email",
                table: "SM_USUARIO",
                newName: "IX_SM_USUARIO_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SM_SISTEMA",
                table: "SM_SISTEMA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SM_SENSOR",
                table: "SM_SENSOR",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SM_PAINEL_SOLAR",
                table: "SM_PAINEL_SOLAR",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SM_MONITORAMENTO",
                table: "SM_MONITORAMENTO",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SM_USUARIO",
                table: "SM_USUARIO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SM_MONITORAMENTO_SM_SENSOR_SensorId",
                table: "SM_MONITORAMENTO",
                column: "SensorId",
                principalTable: "SM_SENSOR",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SM_PAINEL_SOLAR_SM_SISTEMA_SistemaId",
                table: "SM_PAINEL_SOLAR",
                column: "SistemaId",
                principalTable: "SM_SISTEMA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SM_SENSOR_SM_SISTEMA_SistemaId",
                table: "SM_SENSOR",
                column: "SistemaId",
                principalTable: "SM_SISTEMA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SM_SISTEMA_SM_USUARIO_ClienteId",
                table: "SM_SISTEMA",
                column: "ClienteId",
                principalTable: "SM_USUARIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SM_MONITORAMENTO_SM_SENSOR_SensorId",
                table: "SM_MONITORAMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_SM_PAINEL_SOLAR_SM_SISTEMA_SistemaId",
                table: "SM_PAINEL_SOLAR");

            migrationBuilder.DropForeignKey(
                name: "FK_SM_SENSOR_SM_SISTEMA_SistemaId",
                table: "SM_SENSOR");

            migrationBuilder.DropForeignKey(
                name: "FK_SM_SISTEMA_SM_USUARIO_ClienteId",
                table: "SM_SISTEMA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SM_USUARIO",
                table: "SM_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SM_SISTEMA",
                table: "SM_SISTEMA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SM_SENSOR",
                table: "SM_SENSOR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SM_PAINEL_SOLAR",
                table: "SM_PAINEL_SOLAR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SM_MONITORAMENTO",
                table: "SM_MONITORAMENTO");

            migrationBuilder.RenameTable(
                name: "SM_USUARIO",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "SM_SISTEMA",
                newName: "Sistemas");

            migrationBuilder.RenameTable(
                name: "SM_SENSOR",
                newName: "Sensores");

            migrationBuilder.RenameTable(
                name: "SM_PAINEL_SOLAR",
                newName: "PaineisSolares");

            migrationBuilder.RenameTable(
                name: "SM_MONITORAMENTO",
                newName: "Monitoramentos");

            migrationBuilder.RenameIndex(
                name: "IX_SM_USUARIO_Email",
                table: "Clientes",
                newName: "IX_Clientes_Email");

            migrationBuilder.RenameIndex(
                name: "IX_SM_SISTEMA_ClienteId",
                table: "Sistemas",
                newName: "IX_Sistemas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_SM_SENSOR_SistemaId",
                table: "Sensores",
                newName: "IX_Sensores_SistemaId");

            migrationBuilder.RenameIndex(
                name: "IX_SM_PAINEL_SOLAR_SistemaId",
                table: "PaineisSolares",
                newName: "IX_PaineisSolares_SistemaId");

            migrationBuilder.RenameIndex(
                name: "IX_SM_MONITORAMENTO_SensorId",
                table: "Monitoramentos",
                newName: "IX_Monitoramentos_SensorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sistemas",
                table: "Sistemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sensores",
                table: "Sensores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaineisSolares",
                table: "PaineisSolares",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monitoramentos",
                table: "Monitoramentos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitoramentos_Sensores_SensorId",
                table: "Monitoramentos",
                column: "SensorId",
                principalTable: "Sensores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaineisSolares_Sistemas_SistemaId",
                table: "PaineisSolares",
                column: "SistemaId",
                principalTable: "Sistemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sensores_Sistemas_SistemaId",
                table: "Sensores",
                column: "SistemaId",
                principalTable: "Sistemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sistemas_Clientes_ClienteId",
                table: "Sistemas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
