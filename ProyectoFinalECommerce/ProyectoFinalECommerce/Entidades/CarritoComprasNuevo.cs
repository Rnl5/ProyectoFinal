using ProyectoFinalECommerce.Data;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalECommerce.Entidades
{
    public class CarritoComprasNuevo
    {
        [Key]
        public int CarritoComprasNuevoId {  get; set; }

        public ApplicationUser User { get; set; }

        public string? UserId { get; set; }

        public ProductosNuevo ProductosNuevo { get; set;}

        public int ProductoNuevoId { get; set; }

        public decimal Cantidad { get; set; }

        public string? Observaciones {  get; set; }

        public decimal Valor => ProductosNuevo == null ? 0 : ProductosNuevo.PrecioOriginal * (decimal)Cantidad;
    }
}
