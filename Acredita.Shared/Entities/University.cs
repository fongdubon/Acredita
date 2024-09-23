using System.ComponentModel.DataAnnotations;

namespace Acredita.Shared.Entities
{
    public class University
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Universidad")]
        [MaxLength(100, ErrorMessage = "El campo {0} no pude tener más de {1} caracteres")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Sitio web")]
        [MaxLength(200, ErrorMessage = "El campo {0} no pude tener más de {1} caracteres")]
        public string Url { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Teléfono")]
        [MaxLength(10, ErrorMessage = "El campo {0} no pude tener más de {1} caracteres")]
        public string PhoneNumber { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Dirección")]
        [MaxLength(200, ErrorMessage = "El campo {0} no pude tener más de {1} caracteres")]
        public string Address { get; set; } = null!;
        public bool Active { get; set; }

    }
}
