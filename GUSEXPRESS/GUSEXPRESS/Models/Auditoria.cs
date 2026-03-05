using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Auditoria
    {
        [Key]
        public int Id { get; set; }

        public string? tablaAfectada { get; set; }

        public string? Accion { get; set; }

        public int? UsuarioID { get; set; }

        [ForeignKey("UsuarioId")]

        public Usuario Usuarios { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
