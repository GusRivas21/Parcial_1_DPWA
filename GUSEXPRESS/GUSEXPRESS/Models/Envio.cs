using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Envio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioID { get; set; }

        [ForeignKey("UsuarioId")]

        public Usuario Usuarios { get; set; }

        [Required]
        public int DestinatarioId { get; set; }

        [ForeignKey("DestinatarioId")]

        public Destinatario Destinatarios { get; set; }

        [Required]
        public int EstadoEnvioId { get; set; }

        [ForeignKey("EstadoEnvioId")]

        [Required]
        public EstadoEnvio EstadoEnvios { get; set; }

        [Required]
        public DateTime FechaEnvio { get; set; } = DateTime.Now;

        [Required]
        public DateTime FechaEntrega { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public int Costo { get; set; }

        public ICollection<Paquete> Paquetes { get; set; }
    }
}
