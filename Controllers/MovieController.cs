using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_22.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_22.Controllers
{
    public class MovieController : Controller
    {
        public static List<Movie> Movies = new List<Movie>
        {
          new Movie("Halloween", "Horror"),
          new Movie("Cool Runnings", "Sci-Fi"),
          new Movie("White Chicks", "Comedy"),
          new Movie("Scary Movie", "Ramance"),
          new Movie("Friday", "Drama")
        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult SearchResultGenre(string genre)
        {
            List<Movie> genreList = new List<Movie>();

            foreach (Movie movie in Movies)
            {
                if (movie.Genre == genre)
                {
                    genreList.Add(movie);
                }
            }
            return View(genreList);
        }
        public IActionResult SearchResultTitle(string title)
        {
            foreach (Movie movie in Movies)
            {
                if (movie.Title.ToLower() == title.ToLower())
                {
                    return View(movie);
                }

            }

            return View();
        }
    }
}