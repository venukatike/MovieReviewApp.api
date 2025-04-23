using System;

namespace MovieReviewApp.api.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; } // 1 to 5
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public string UserName { get; set; } // Optional: Link to user system later
    }
}
