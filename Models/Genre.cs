using System.ComponentModel.DataAnnotations;

namespace Dash_Movies.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="El Nombre de genero no puede ser tan largo.")]
        public string Name { get; set; }

    }
}