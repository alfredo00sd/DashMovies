using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dash_Movies.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "El nombre no puede ser tan largo :(")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genero")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }


        [Display(Name = "Fecha de lanzamiento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Numero de copias existentes")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Peliculas disponibles")]
        [Range(1, 20)]
        public byte NumberAvailable { get; set; }

    }
}