using System;
using System.ComponentModel.DataAnnotations;

namespace Dash_Movies.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateRented { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateReturned { get; set; }

    }
}