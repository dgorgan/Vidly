using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //List<string> actors = new List<string> {
        //    "just", "putting", "something", "inside", "the", "list"
        //};

        public string Title { get; set; }
        public int Year { get; set; }
        public string Rated { get; set; }
        public DateTime Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        //public List<actors> Actors { get; set; }
        public string Plot { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public int Metascore { get; set; }
        public Double ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string BoxOffice { get; set; }
        public string Website { get; set; }

    }
}

