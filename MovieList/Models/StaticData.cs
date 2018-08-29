using System.Collections.Generic;
namespace MovieList.Models
{
    public class StaticData
    {
        public  List<Movie> GetMoviedata()
        {
            return new List<Movie>
            {
                new Movie
                {
                    MovieID = 1,
                    MovieName = "Avengers",
                    MovieYear = 2013,
                    MovieType = "Science-Fiction"
                },
                new Movie
                {
                    MovieID = 2,
                    MovieName = "3 idiots",
                    MovieYear = 2009,
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
                    MovieName = "Dangal",
                    MovieYear = 2012,
                    MovieType = "Action"
                },
                new Movie
                {
                    MovieID = 5,
                    MovieName = "Anand",
                    MovieYear = 1971,
                    MovieType = "Romantic"
                }
            };
        }
    }
}
