using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalECommerce.Shared;

public class Carrito
{
    [Key]
    public int CarritoId { get; set; }

    public int ProductoId { get; set; }

    [Required(ErrorMessage ="El campo {0} es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public double Precio { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public int Cantidad {  get; set; }

}
