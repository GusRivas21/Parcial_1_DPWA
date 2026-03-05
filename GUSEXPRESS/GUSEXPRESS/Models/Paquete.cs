using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUSEXPRESS.Models
{
    public class Paquete
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EnvioId { get; set; }

        [ForeignKey("EnvioId")]

        public Envio Envios { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal peso { get; set; }
    }
}
