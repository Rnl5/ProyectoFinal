using ProyectoFinalECommerce.Entidades;
using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Servicios.ServicioProductoNuevo
{
    public class ServicioProductoNuevo : IServicioProductoNuevo
    {
        private readonly HttpClient httpClient;

        public List<ProductosNuevo> productoNuevo { get; set; } = new List<ProductosNuevo>();

        public ServicioProductoNuevo(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task CargarProductosNuevo(string ruta)
        {
            productoNuevo = await httpClient.GetFromJsonAsync<List<ProductosNuevo>>(ruta);
        }
    }
}
