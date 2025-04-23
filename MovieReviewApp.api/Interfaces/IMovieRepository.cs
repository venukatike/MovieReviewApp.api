using MovieReviewApp.api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReviewApp.api.Interfaces
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task<Movie> AddAsync(Movie movie);
        Task<Movie> UpdateAsync(Movie movie);
        Task<bool> DeleteAsync(int id);
    }
}
