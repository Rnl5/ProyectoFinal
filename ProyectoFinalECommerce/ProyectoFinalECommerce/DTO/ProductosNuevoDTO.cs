namespace ProyectoFinalECommerce.DTO
{
    public class ProductosNuevoDTO
    {
        public int ProductoNuevoDTOId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public decimal Precio { get; set; }

        public decimal Existencia { get; set; }

        public List<int>? CategoriaProductoId { get; set; }

        public List<string>? ImagenProducto {  get; set; }
    }
}
