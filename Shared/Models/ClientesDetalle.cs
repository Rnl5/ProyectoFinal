using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ClientesDetalle
{
    [Key]
    public int DetalleIdCliente {get; set;}

    [ForeignKey("ClienteId")]
    public int ClienteId {get; set;}

    [ForeignKey("TipoTelId")]
    public int TipoTelId {get; set;}

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo {0} solo debe contener letras")]
    public string Nombre { get; set;} = string.Empty;

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Telefono { get; set;} = string.Empty;
}