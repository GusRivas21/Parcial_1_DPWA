using System.ComponentModel.DataAnnotations;

namespace GUSEXPRESS.Models
{
    public class Producto
    {
        [Key]

        public int Id { get; set; }

        public string? Nombre { get; set; }

        public int? Cantidad { get; set; }

        public string? Tamanio { get; set; }
    }
}
