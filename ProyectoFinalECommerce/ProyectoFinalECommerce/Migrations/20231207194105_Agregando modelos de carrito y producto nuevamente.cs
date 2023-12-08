using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalECommerce.Migrations
{
    /// <inheritdoc />
    public partial class Agregandomodelosdecarritoyproductonuevamente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductosNuevos",
                columns: table => new
                {
                    ProductoNuevoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    PrecioOferta = table.Column<decimal>(type: "TEXT", nullable: false),
                    PrecioOriginal = table.Column<decimal>(type: "TEXT", nullable: false),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosNuevos", x => x.ProductoNuevoId);
                });

            migrationBuilder.CreateTable(
                name: "CarritoComprasNuevos",
                columns: table => new
                {
                    CarritoComprasNuevoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    ProductosNuevoProductoNuevoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoNuevoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<decimal>(type: "TEXT", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoComprasNuevos", x => x.CarritoComprasNuevoId);
                    table.ForeignKey(
                        name: "FK_CarritoComprasNuevos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarritoComprasNuevos_ProductosNuevos_ProductosNuevoProductoNuevoId",
                        column: x => x.ProductosNuevoProductoNuevoId,
                        principalTable: "ProductosNuevos",
                        principalColumn: "ProductoNuevoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarritoComprasNuevos_ProductosNuevoProductoNuevoId",
                table: "CarritoComprasNuevos",
                column: "ProductosNuevoProductoNuevoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoComprasNuevos_UserId",
                table: "CarritoComprasNuevos",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarritoComprasNuevos");

            migrationBuilder.DropTable(
                name: "ProductosNuevos");
        }
    }
}
