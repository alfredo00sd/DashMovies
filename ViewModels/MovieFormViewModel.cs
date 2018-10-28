using Dash_Movies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dash_Movies.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "El nombre es demasiado largo :(")]
        public string Name { get; set; }

        [Display(Name = "Genero")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Numero de copias existentes")]
        [Range(1, 50)]
        [Required]
        public byte? NumberInStock { get; set; }
        [Display(Name = "Numero de copias existentes")]
        [Range(1, 50)]
        public byte? NumberAvailable { get; set; }

        [Display(Name = "Descripcion de la pelicula")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "La descripcion es una sinopsis que no puede exeder los 500 caracteres")]
        public string Description { get; set; }
        [Display(Name = "Imagenes")]
        [DataType(DataType.ImageUrl)]
        public string ImagenUrl { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            Description = movie.Description;
            ImagenUrl = movie.ImagenUrl;
        }
    }
}
