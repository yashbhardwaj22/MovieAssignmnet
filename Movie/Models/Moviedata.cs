using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Movie.Models
{

    public class Moviedata
    {
        public ArrayList getData()
        {
            ArrayList movieData = new ArrayList();
            MovieStore storeData = new MovieStore
            {
                movieID = 1,
                movieName = "titanic",
                movieYear = 1991,
                movieGenre = "romantic"

            };

            movieData.Add(storeData);

             storeData = new MovieStore
            {
                movieID = 1,
                movieName = "twilight",
                movieYear = 1991,
                movieGenre = "romantic"

            };

            movieData.Add(storeData);

            storeData = new MovieStore
            {
                movieID = 1,
                movieName = "titanic",
                movieYear = 1991,
                movieGenre = "romantic"

            };

            movieData.Add(storeData);
            storeData = new MovieStore
            {
                movieID = 1,
                movieName = "titanic",
                movieYear = 1991,
                movieGenre = "romantic"

            };

            movieData.Add(storeData);
            storeData = new MovieStore
            {
                movieID = 1,
                movieName = "titanic",
                movieYear = 1991,
                movieGenre = "romantic"

            };

            movieData.Add(storeData);
            return movieData;


        }
    }
}

