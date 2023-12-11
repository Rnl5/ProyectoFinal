using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Client.Services.ServicioCategoria
{
    public interface IServicioCategoria
    {
        public IEnumerable<Categorias> L_Categorias { get; set; }

        Task CargarCategorias();
    }
}
