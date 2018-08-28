using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public int MovieYear { get; set; }
        public string MovieType { get; set; }
    }
}
