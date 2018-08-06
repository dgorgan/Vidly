using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            Movie movie = new Movie()
            {
                Title = "Guardians of the Galaxy Vol. 2",
                Year = 2017,
                Rated = "PG-13",
                Released = DateTime.Now,
                Runtime = "136 min",
                Genre = "Action, Adventure, Sci-Fi",
                Director = "James gunn",
                Plot = "The Guardians must fight to keep their newfound family together as they unravel the mystery of Peter Quill's true parentage.",
                Country = "USA",
                Awards = "Nominated for 1 Oscar. Another 12 wins & 42 nominations.",
                Poster = "https://m.media-amazon.com/images/M/MV5BMTg2MzI1MTg3OF5BMl5BanBnXkFtZTgwNTU3NDA2MTI@._V1_SX300.jpg",
                Metascore = 67,
                ImdbRating = 7.7,
                ImdbVotes = "397,820",
                BoxOffice = "$389,804,217",
                Website = "https://marvel.com/guardians"
            };

            
            return View(movie);
        }
    }
}
