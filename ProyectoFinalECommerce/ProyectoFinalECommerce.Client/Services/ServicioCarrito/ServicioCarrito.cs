using Blazored.SessionStorage;
using ProyectoFinalECommerce.Client.Services.ServicioProducto;
using ProyectoFinalECommerce.Shared;
using System.Net.Http.Json;

namespace ProyectoFinalECommerce.Client.Services.ServicioCarrito
{
    public class ServicioCarrito : IServicioCarrito
    {
        private readonly ISessionStorageService sessionStorageService;

        private readonly IServicioProducto servicioProducto;
        

        public event Action OnChange;

        public ServicioCarrito(ISessionStorageService sessionStorageService, IServicioProducto servicioProducto)
        {
            this.sessionStorageService = sessionStorageService;
            this.servicioProducto = servicioProducto;
        }

        public async Task AgregarAlCarrito(Productos producto)
        {
            var carrito = await sessionStorageService.GetItemAsync<List<Productos>>("carritoCompras");

            if(carrito == null)
            {
                carrito = new List<Productos>();
            }

            carrito.Add(producto);
            await sessionStorageService.SetItemAsync("carritoCompras", carrito);

            OnChange?.Invoke();
        }

        public async Task EliminarArticulo(ProductosCarrito producto)
        {
            var carrito = await sessionStorageService.GetItemAsync<List<Productos>>("carritoCompras");

            if(carrito == null)
            {
                return;
            }

            var productoAEliminar = carrito.Find(p => p.ProductoId == producto.ProductoId);

            carrito.Remove(productoAEliminar);

            await sessionStorageService.SetItemAsync("carritoCompras", carrito);

            OnChange?.Invoke();
        }

        public Task Guardar(ProductosCarrito articulo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductosCarrito>> ObtenerArticulosEnCarrito()
        {
            var resultado = new List<ProductosCarrito>();

            var carrito = await sessionStorageService.GetItemAsync<List<Productos>>("carritoCompras");

            if(carrito == null)
            {
                return resultado;
            }

            foreach(var producto in carrito)
            {
                var articulo = await servicioProducto.ObtenerProductos(producto.ProductoId);

                var articloEnCarrito = new ProductosCarrito
                {
                    ProductoId = articulo.ProductoId,
                    NombreProducto = articulo.Nombre,
                    Precio = articulo.Precio,
                    Imagen = articulo.Foto,
                };
                resultado.Add(articloEnCarrito);
            }

            return resultado;
           
        }
    }
}
