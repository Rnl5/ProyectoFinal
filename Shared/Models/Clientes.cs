using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinalECommerce.Shared;

public class Clientes
{
    [Key]
    public int ClienteId {get; set;}

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo {0} solo debe contener letras")]
    public string Nombre {get; set;} = string.Empty;

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo {0} solo debe contener letras")]
    public string Apellido {get; set;} = string.Empty;

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public DateTime FechaNacimiento { get; set; } = DateTime.Now.AddYears(-20);

    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "El campo {0} no es valido")]
    public string Cedula { get; set;} = string.Empty;

    [ForeignKey("ClienteId")]
    public ICollection<ClientesDetalle> ClientesDetalle { get; set; } = new List<ClientesDetalle>(); 
}