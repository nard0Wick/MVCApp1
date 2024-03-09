using Microsoft.AspNetCore.Mvc.Rendering; 
using System.Collections.Generic;

namespace MVCApp1.Models
{
    public class MovieGenreViewModel
    { 
        public List<Movie>? Movies; //lista de películas
        public SelectList? Genres { get; set; } //lista de generos
        public string? MovieGenre { get; set; } 
        public string? SearchString { get; set; }
    }
}
