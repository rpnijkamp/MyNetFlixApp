using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetflixApp.Models;

namespace MyNetflixApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Hier maken we een lijst van movies aan.
            var movies = new List<Movie>();

            // we maken een movie
            var movie = new Movie("MyMovieTitle", new DateTime(2019,7,30));
            movie.Category = "Action";

            // we maken een movie
            var movie2 = new Movie("Transformers", new DateTime(2012, 7, 30));
            movie2.Category = "Scifiction";

            // We vullen de lijst van movies met onze movies.
            movies.Add(movie);
            movies.Add(movie2);

            // we geven de lijst aan de html pagina.
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
