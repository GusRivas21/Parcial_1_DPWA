using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Envio
    {
        [Key]
        public int Id { get; set; }

        public int? UsuarioID { get; set; }

        [ForeignKey("UsuarioId")]

        public Usuario Usuarios { get; set; }

        public int? DestinatarioId { get; set; }

        [ForeignKey("DestinatarioId")]

        public Destinatario Destinatarios { get; set; }

        public int? EstadoEnvioId { get; set; }

        [ForeignKey("EstadoEnvioId")]


        public EstadoEnvio EstadoEnvios { get; set; }

        public DateTime FechaEnvio { get; set; } = DateTime.Now;

        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public int? Costo { get; set; }

        public ICollection<Paquete> Paquetes { get; set; }
    }
}
