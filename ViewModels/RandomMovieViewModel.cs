using Dash_Movies.Models;
using System.Collections.Generic;

namespace Dash_Movies.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}