using System.Collections.Generic;
using System;

namespace MovieReviewApp.api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
