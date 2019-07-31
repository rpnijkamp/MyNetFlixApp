using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetflixApp.Models
{
    public class Movie
    {
        public Movie(string title, DateTime releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
        }

        public string Summary { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public int Rating { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
