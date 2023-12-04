using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Client.Services.ServicioCategoria
{
    public class ServicioCategoria : IServicioCategoria
    {
        public List<Categorias> Categorias { get; set; } = new List<Categorias>();

        public void CargarCategorias()
        {
            Categorias = new List<Categorias>
            {
                new Categorias
                {
                    CategoriaId = 1,
                    Nombre = "Electrodomesticos",
                    Url ="electrodomesticos",
                    Icon = "camera-slr"
                },
                new Categorias
                {
                    CategoriaId = 2,
                    Nombre = "Productos del Hogar",
                    Url ="productosDelHogar",
                    Icon = "camera-slr"
                },
                new Categorias
                {
                    CategoriaId = 3,
                    Nombre = "Televisores",
                    Url ="televisores",
                    Icon = "camera-slr"
                }

            };
        }
    }
}
