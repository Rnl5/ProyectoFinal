using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Client.Services.ServicioCarrito
{
    public interface IServicioCarrito
    {
        Task<IEnumerable<Carrito>> GetCarrito();

        void AgregarCarrito(Carrito objeto);
    }
}
