using System;

namespace MovieReviewApp.api.DTOs
{
    public class CreateMovieDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }
    }
}
