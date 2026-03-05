using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Auditoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string tablaAfectada { get; set; }

        [Required]
        public string Accion { get; set; }

        [Required]
        public int UsuarioID { get; set; }

        [ForeignKey("UsuarioId")]

        public Usuario Usuarios { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
