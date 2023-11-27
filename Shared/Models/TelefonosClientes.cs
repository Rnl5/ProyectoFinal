using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalECommerce.Shared;
public class TelefonosClientes
{
    [Key]
    public int TipoTelId {get; set;}

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string TipoTelefono { get; set; } = string.Empty;
}