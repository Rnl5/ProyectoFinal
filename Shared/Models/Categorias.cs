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

    public string Nombre { get; set; }

    public string Url { get; set; }

    public string Icon { get; set; }

}
