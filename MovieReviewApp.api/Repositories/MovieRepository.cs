using Microsoft.EntityFrameworkCore;
using MovieReviewApp.api.Data;
using MovieReviewApp.api.Interfaces;
using MovieReviewApp.api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReviewApp.api.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetAllAsync() => await _context.Movies.ToListAsync();

        public async Task<Movie> GetByIdAsync(int id) => await _context.Movies.FindAsync(id);

        public async Task<Movie> AddAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> UpdateAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return false;
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
