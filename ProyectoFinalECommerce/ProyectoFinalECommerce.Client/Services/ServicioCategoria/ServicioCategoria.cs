using ProyectoFinalECommerce.Shared;
using System.Net.Http.Json;

namespace ProyectoFinalECommerce.Client.Services.ServicioCategoria
{
    public class ServicioCategoria : IServicioCategoria
    {
        private readonly HttpClient httpClient;

        public IEnumerable<Categorias> L_Categorias { get; set; } = Enumerable.Empty<Categorias>();
        //public List<Categorias> Categorias { get; set; } = new List<Categorias>();

        public ServicioCategoria(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task CargarCategorias()
        {
            L_Categorias = await httpClient.GetFromJsonAsync<List<Categorias>>("api/Categorias");
        }
    }
}
