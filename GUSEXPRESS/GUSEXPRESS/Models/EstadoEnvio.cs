using System.ComponentModel.DataAnnotations;

namespace GUSEXPRESS.Models
{
    public class EstadoEnvio
    {
        [Key]

        public int Id { get; set; }

        [StringLength(100)]
        public string? NombreEstado { get; set; }

        [StringLength(200)]
        public string? Descripcion { get; set; }

        [StringLength(200)]
        public ICollection<Envio> Envios { get; set; }

    }
}
