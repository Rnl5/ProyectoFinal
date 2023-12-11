using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Client.Services.ServicioCarrito
{
    public interface IServicioCarrito
    {
        event Action OnChange;

        Task AgregarAlCarrito(Productos producto);

        Task<List<ProductosCarrito>> ObtenerArticulosEnCarrito();

        Task EliminarArticulo(ProductosCarrito articulo);

        Task Guardar(ProductosCarrito articulo);
    }
}
