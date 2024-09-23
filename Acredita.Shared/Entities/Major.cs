using System.ComponentModel.DataAnnotations;

namespace Acredita.Shared.Entities
{
    public class Major
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Carrera")]
        [MaxLength(100, ErrorMessage = "El campo {0} no pude tener más de {1} caracteres")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Duración")]
        public int Duration { get; set; }
        public bool Active { get; set; }
    }
}
