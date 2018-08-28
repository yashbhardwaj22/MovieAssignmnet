using System.Collections.Generic;
namespace MovieList.Models
{
    public class MovieData
    {
        public List<Movie> getMoviedata()
        {
            return new List<Movie>
            {
                new Movie
                {
                    MovieID = 1,
                    MovieName = "Titanic",
                    MovieYear = 1992,
                    MovieType = "Romantic"
                },
                new Movie
                {
                    MovieID = 2,
                    MovieName = "Bahubali",
                    MovieYear = 2017,
                    MovieType = "Fiction"
                },
                new Movie
                {
                    MovieID = 3,
                    MovieName = "Avengers",
                    MovieYear = 2013,
                    MovieType = "Science-Fiction"

                },
                new Movie
                {
                     MovieID = 4,
                    MovieName = "Underworld",
                    MovieYear = 2010,
                    MovieType = "Action"
                },
                new Movie
                {
                    MovieID = 5,
                    MovieName = "Twilight",
                    MovieYear = 2011,
                    MovieType = "Romantic"
                }
            };
        }
    }
}
