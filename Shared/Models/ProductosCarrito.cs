using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalECommerce.Shared;

public class ProductosCarrito
{
    [Key]
    public int ProductoId { get; set; }

    public string NombreProducto { get; set; } = string.Empty;

    public double Precio { get; set; }

    public byte[]? Imagen { get; set; }

    public int? Cantidad { get; set; }
}
