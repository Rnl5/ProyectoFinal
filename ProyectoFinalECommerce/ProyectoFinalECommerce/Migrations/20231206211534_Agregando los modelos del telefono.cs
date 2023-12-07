using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalECommerce.Migrations
{
    /// <inheritdoc />
    public partial class Agregandolosmodelosdeltelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsPublico",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EstaBorrado",
                table: "Productos");

            migrationBuilder.CreateTable(
                name: "UsuariosDetalle",
                columns: table => new
                {
                    DetalleIdCliente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TipoTelId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosDetalle", x => x.DetalleIdCliente);
                    table.ForeignKey(
                        name: "FK_UsuariosDetalle_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosDetalle_Id",
                table: "UsuariosDetalle",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosDetalle");

            migrationBuilder.AddColumn<bool>(
                name: "EsPublico",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EstaBorrado",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
