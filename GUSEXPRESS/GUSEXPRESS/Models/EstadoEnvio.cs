using System.ComponentModel.DataAnnotations;

namespace GUSEXPRESS.Models
{
    public class EstadoEnvio
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreEstado { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
