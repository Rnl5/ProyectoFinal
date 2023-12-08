using ProyectoFinalECommerce.Entidades;
using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Servicios.ServicioProductoNuevo
{
    public interface IServicioProductoNuevo
    {
        List<ProductosNuevo> productoNuevo { get; set; }

        Task CargarProductosNuevo(string ruta);
    }
}

