using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Destinatario
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(100)]
        public string? Telefono { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }

        [StringLength(200)]
        public string? Ciudad { get; set; }

        [StringLength(100)]
        public string? Pais { get; set; }

        public int? UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuarios{ get; set; }

        public ICollection<Envio> Envios { get; set; }
    }
}
