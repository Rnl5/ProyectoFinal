using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinalECommerce.Entidades
{
    public class ProductosNuevo
    {
        [Key]
        public int ProductoNuevoId {  get; set; }

        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }

        public DateTime Fecha {  get; set; } = DateTime.Now;

        public string Descripcion { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public decimal PrecioOferta { get; set; }

        public decimal PrecioOriginal { get; set; }

        public byte[]? Foto { get; set; }

       public ICollection<CarritoComprasNuevo>? CarritoComprasNuevos { get; set; }
    }
}
