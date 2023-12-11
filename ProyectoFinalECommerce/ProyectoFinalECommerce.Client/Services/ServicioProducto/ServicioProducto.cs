using Microsoft.AspNetCore.Components;
using ProyectoFinalECommerce.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProyectoFinalECommerce.Client.Services.ServicioProducto
{
    public class ServicioProducto : IServicioProducto
    {
        private readonly HttpClient httpClient;

        public List<Productos> productos { get; set; } = new List<Productos>();
        


        public ServicioProducto(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task CargarProductos(string ruta)
        {
            productos = await httpClient.GetFromJsonAsync<List<Productos>>(ruta);
        }

        public async Task<Productos> ObtenerProductos(int productoId)
        {
            return await httpClient.GetFromJsonAsync<Productos>($"api/Productos/{productoId}");
        }
    }
}
