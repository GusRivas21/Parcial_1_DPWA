using System.ComponentModel.DataAnnotations;

namespace GUSEXPRESS.Models
{
    public class Producto
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public string Tamanio { get; set; }
    }
}
