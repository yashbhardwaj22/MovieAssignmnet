using System.Collections.Generic;

namespace MovieList.Models
{
    public class MovieViewModel
    {
        public int MovieID { get; set; }
        public List<Movie> MovieList { get; set; }
    }
}
