using Microsoft.AspNetCore.Mvc;
using MovieList.Models;
using System.Collections.Generic;
namespace MovieList.Controllers
{
    public class MovieController : Controller
    {
        
        private  ModelView modelView = new ModelView();
        
        private static List<Movie> movieView = GetMovie();
        public IActionResult Index()
        {
            modelView.MovieViewList = movieView;
            return View(modelView);
        }

        [HttpPost]
        public IActionResult Index(ModelView movie)
        {
            ModelView modelview= new ModelView();
            modelview.MovieViewList = SearchByID(movie.MovieID);
            modelview.MovieID = movie.MovieID;
            if (modelview.MovieViewList.Count != 0)
            {    
                return PartialView("_MovieListPartial", modelview.MovieViewList);
            }
            return Json("Not Found");
        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Movie movie)
        {
            movieView.Add(new Movie
            {
                MovieID = movie.MovieID,
                MovieName = movie.MovieName,
                MovieYear = movie.MovieYear,
                MovieType = movie.MovieType
            });

            return RedirectToAction("Index", "Movie");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            bool isFound = false;
            foreach(var item in movieView)
            {
                if(item.MovieID == movie.MovieID)
                {
                    isFound = true;
                    item.MovieName = movie.MovieName;
                    item.MovieYear = movie.MovieYear;
                    item.MovieType = movie.MovieType;
                }
            }
            if (isFound)
            {
                return RedirectToAction("Index", "Movie");
            }
            return NotFound();          
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            bool isPresent = false;
            Movie removeMovieData = new Movie();
            foreach (var item in movieView)
            {
                if (item.MovieID == movie.MovieID)
                {
                    isPresent = true;
                    removeMovieData = item;
                }
            }           
            if (isPresent)
            {
                movieView.Remove(removeMovieData);
                return RedirectToAction("Index", "Movie");
            }
            return NotFound();
        }      
        private static List<Movie> GetMovie()
        {
            StaticData data = new StaticData();
            return data.GetMoviedata();
        }
        private List<Movie> SearchByID(int movieBind)
        {
            List<Movie> movieData = new List<Movie>();
            foreach(Movie item in movieView)
            {
                if(item.MovieID == movieBind)
                {
                    movieData.Add(item);
                }
            }
            return movieData;
        }       
    }
}