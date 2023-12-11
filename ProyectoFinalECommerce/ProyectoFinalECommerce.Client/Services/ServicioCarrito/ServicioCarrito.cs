using ProyectoFinalECommerce.Shared;
using System.Net.Http.Json;

namespace ProyectoFinalECommerce.Client.Services.ServicioCarrito
{
    public class ServicioCarrito : IServicioCarrito
    {
        private readonly HttpClient httpClient;

        public ServicioCarrito(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public List<Carrito> Objetos { get; set; } = new List<Carrito>();

        public async void AgregarCarrito(Carrito objeto)
        {
            await httpClient.PostAsJsonAsync("api/Carritos", objeto);
        }

        public async Task<IEnumerable<Carrito>> GetCarrito()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Carrito>>("api/Carritos");
        }
    }
}
