using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(100)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Correo { get; set; }

        [StringLength(200)]
        public string? Direccion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public int? RolId { get; set; }

        [ForeignKey("RolId")]

        public Rol Roles { get; set; }

        public ICollection<Envio> Envios { get; set; }
        public ICollection<Destinatario> Destinatarios { get; set; }
    }
}
