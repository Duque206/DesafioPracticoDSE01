using System.ComponentModel.DataAnnotations;

namespace DA202312_desafio1.Models
{
    public class Autor
    {
        public int AutorID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder de 50 caracteres")]
        public string Apellido { get; set; }
    }
}
