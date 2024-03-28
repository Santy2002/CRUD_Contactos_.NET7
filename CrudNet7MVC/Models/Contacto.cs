using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudNet7MVC.Models
{
    [NotMapped]
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo NOMBRE es OBLIGATORIO")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo CELULAR es OBLIGATORIO")]

        public string Celular { get; set; }

        [Required(ErrorMessage = "El campo EMAIL es OBLIGATORIO")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "El campo Email debe contener @")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }


    }
}
