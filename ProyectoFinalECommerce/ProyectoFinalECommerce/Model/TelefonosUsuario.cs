using ProyectoFinalECommerce.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinalECommerce.Model
{
    public class TelefonosUsuario
    {
        [Key]
        
        public int TipoTelId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string TipoTel { get; set; } = string.Empty;

        [ForeignKey("TipoTelId")]
        public ICollection<UsuariosDetalle> UsuariosDetalle { get; set; } = new List<UsuariosDetalle>();
    }
}
