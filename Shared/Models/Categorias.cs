using ProyectoFinalECommerce.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalECommerce.Shared;

public class Categorias
{
    [Key]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Url { get; set; }

}
