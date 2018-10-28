using System;
using System.ComponentModel.DataAnnotations;

namespace Dash_Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "El nombre no puede ser tan largo :(")]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genero")]
        [Required]
        public byte GenreId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Numero de copias existentes")]
        [Range(1, 50)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Peliculas disponibles")]
        [Range(1, 50)]
        public byte NumberAvailable { get; set; }

        [Display(Name = "Descripcion de la pelicula")]
        [DataType(DataType.MultilineText)]
        [StringLength(500,ErrorMessage ="La descripcion es una sinopsis que no puede exeder los 500 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Imagenes")]
        [DataType(DataType.ImageUrl)]
        public string ImagenUrl { get; set; }

    }
}