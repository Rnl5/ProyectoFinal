using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Client.Services.ServicioCategoria
{
    public interface IServicioCategoria
    {
        public List<Categorias> Categorias { get; set; }

        void CargarCategorias();
    }
}
