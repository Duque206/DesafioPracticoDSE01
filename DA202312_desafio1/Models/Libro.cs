using System;
using System.ComponentModel.DataAnnotations;

namespace DA202312_desafio1.Models
{
    public class Libro
    {
        public int LibroID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(100, ErrorMessage = "El título no puede tener más de 100 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de publicación es obligatoria")]
        [Display(Name = "Fecha de Publicación")]
        public DateTime FechaPublicacion { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public int AutorID { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria")]
        public int CategoriaID { get; set; }

        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
