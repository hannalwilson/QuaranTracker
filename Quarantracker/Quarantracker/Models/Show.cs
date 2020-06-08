using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quarantracker.Models
{
    public enum ShowType
    {
        Series, Movie
    }
    public enum Service
    {
        Netflix, Hulu, AmazonPrime, Starz, Showtime, HBO, DisneyPlus, Other
    }
    public class Show
    {
        public int ShowId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public ShowType Type { get; set; }
        public Service? Service { get; set; }

    }
}