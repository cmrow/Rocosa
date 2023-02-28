using System.ComponentModel.DataAnnotations;

namespace Rocosa.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre de categiria es obligatorio")]
        public string NombreCategoria { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="El orden debe ser mayor a cero")]
        [Required(ErrorMessage = "Orden es obligatorio")]
        public int MostrarOrden { get; set; }
    }
}
