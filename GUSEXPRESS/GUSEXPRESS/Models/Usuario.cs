using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public int RolId { get; set; }

        [ForeignKey("RolId")]

        [Required]
        public Rol Roles { get; set; }

        public ICollection<Envio> Envios { get; set; }
        public ICollection<Destinatario> Destinatarios { get; set; }
    }
}
