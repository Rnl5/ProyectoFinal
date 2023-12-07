using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoFinalECommerce.Migrations
{
    /// <inheritdoc />
    public partial class Agregandolosmodelosdeltelefonoenelcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TelefonosClientes",
                keyColumn: "TipoTelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TelefonosClientes",
                keyColumn: "TipoTelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TelefonosClientes",
                keyColumn: "TipoTelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TelefonosClientes",
                keyColumn: "TipoTelId",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "TelefonosUsuario",
                columns: table => new
                {
                    TipoTelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonosUsuario", x => x.TipoTelId);
                });

            migrationBuilder.InsertData(
                table: "TelefonosUsuario",
                columns: new[] { "TipoTelId", "TipoTel" },
                values: new object[,]
                {
                    { 1, "Telefono Local" },
                    { 2, "Celular" },
                    { 3, "Trabajo" },
                    { 4, "Persona Auxiliar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosDetalle_TipoTelId",
                table: "UsuariosDetalle",
                column: "TipoTelId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosDetalle_TelefonosUsuario_TipoTelId",
                table: "UsuariosDetalle",
                column: "TipoTelId",
                principalTable: "TelefonosUsuario",
                principalColumn: "TipoTelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosDetalle_TelefonosUsuario_TipoTelId",
                table: "UsuariosDetalle");

            migrationBuilder.DropTable(
                name: "TelefonosUsuario");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosDetalle_TipoTelId",
                table: "UsuariosDetalle");

            migrationBuilder.InsertData(
                table: "TelefonosClientes",
                columns: new[] { "TipoTelId", "TipoTelefono" },
                values: new object[,]
                {
                    { 1, "Telefono Local" },
                    { 2, "Celular" },
                    { 3, "Trabajo" },
                    { 4, "Persona Auxiliar" }
                });
        }
    }
}
