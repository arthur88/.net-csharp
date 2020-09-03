using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; } //list of movies
        public SelectList Genres { get; set; } //select list containing the list of genres
        public SelectList Titles { get; set; } //select list containing list of 
        public string MovieGenre { get; set; } //contain selected genre
        public string MovieTitle { get; set; } //contain selected ratingratings

        public string SearchString { get; set; } //contain entered text in search
    }
}
