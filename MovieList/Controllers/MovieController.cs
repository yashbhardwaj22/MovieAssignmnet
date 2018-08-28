using Microsoft.AspNetCore.Mvc;
using MovieList.Models;
using System.Collections.Generic;
namespace MovieList.Controllers
{
    public class MovieController : Controller
    {
        
        private MovieViewModel movieViewModel = new MovieViewModel();
        private List<Movie> movieDataView;
        public MovieController()
        {
            movieViewModel.MovieList = GetMovieData();
            movieDataView = GetMovieData();
        }
        public IActionResult Index()
        {
            return View(movieViewModel);
        }

        [HttpPost]
        public IActionResult Index(MovieViewModel movie)
        {
            MovieViewModel viewModel= new MovieViewModel();
            List<Movie> movieData = SearchByID(movie.MovieID);
            viewModel.MovieID = movie.MovieID;
            viewModel.MovieList = movieData;
            if (movieViewModel.MovieList.Count != 0)
            {    
                return PartialView("_ShowMovieListPartial", viewModel.MovieList);
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
            movieDataView.Add(new Movie
            {
                MovieID = movie.MovieID,
                MovieName = movie.MovieName,
                MovieYear = movie.MovieYear,
                MovieType = movie.MovieType
            });

            return RedirectToAction("Update", "Movie");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            bool isFound = false;
            foreach(var item in movieDataView)
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
            bool isFound = false;
            Movie tempMovieData = new Movie();
            foreach (var item in movieDataView)
            {
                if (item.MovieID == movie.MovieID)
                {
                    isFound = true;
                    tempMovieData = item;
                }
            }           
            if (isFound)
            {
                movieDataView.Remove(tempMovieData);
                return RedirectToAction("Index", "Movie");
            }
            return NotFound();
        }      
        private List<Movie> GetMovieData()
        {
            MovieData data = new MovieData();
            return data.getMoviedata();
        }
        private List<Movie> SearchByID(int movieDataBind)
        {
            List<Movie> movieData = new List<Movie>();
            foreach(Movie item in movieDataView)
            {
                if(item.MovieID == movieDataBind)
                {
                    movieData.Add(item);
                }
            }
            return movieData;
        }       
    }
}