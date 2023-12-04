using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProyectoFinalECommerce.Shared;

public class Productos
{
    [Key]
    public int ProductoId {get; set;}

    [ForeignKey("CategoriaId")]
    public int CategoriaId { get; set;}


    [Required(ErrorMessage = "Este campo es nesesario")]
    public DateTime Fecha {get; set;}
    [Required(ErrorMessage = "Este campo es necesario")]
    public string Descripcion { get; set; } = string.Empty;
    [Required(ErrorMessage = "Este campo es necesario")]
    public string Nombre { get; set; } = string.Empty;
    [Required(ErrorMessage = "Este campo es necesario")]
    public double Precio { get; set; }

    public double PrecioOriginal { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public byte[]? Foto { get; set; }

    public bool EsPublico { get; set; }

    public bool EstaBorrado {  get; set; }
}