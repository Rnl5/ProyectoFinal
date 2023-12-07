using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalECommerce.Model
{
    public class UsuariosDetalle
    {
        [Key]
        public int DetalleIdCliente { get; set; }

        [ForeignKey("Id")]
        public string Id { get; set; }

        [ForeignKey("TipoTelId")]
        public int TipoTelId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo {0} solo debe contener letras")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Telefono { get; set; } = string.Empty;
    }

}
