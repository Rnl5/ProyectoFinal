using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Client.Services.ServicioProducto
{
    public interface IServicioProducto
    {
        List<Productos> productos { get; set; }

        Task CargarProductos(string requestUrl);
    }
}
