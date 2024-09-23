using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acredita.Shared.Entities
{
    public class Laboratory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre del laboratorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripción del laboratorio")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Tipo de laboratorio")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Type { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Capacidad del laboratorio")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Instrumentos y herramientas disponibles")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Equipment { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Edificio y número")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Location { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Horarios de funcionamiento")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Schedule { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Persona encargada del laboratorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string PersonInCharge { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "¿Requiere alguna norma específica para su uso?")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string SafetyRequirements { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado del laboratorio")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Status { get; set; } = null!;

        public bool Active { get; set; }
    }
}
