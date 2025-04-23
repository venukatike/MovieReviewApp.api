using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieReviewApp.api.DTOs;
using MovieReviewApp.api.Interfaces;
using MovieReviewApp.api.Models;

namespace MovieReviewApp.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;

        public MoviesController(IMovieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MovieDto>>> GetAll()
        {
            var movies = await _repo.GetAllAsync();
            return Ok(_mapper.Map<List<MovieDto>>(movies));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDto>> Get(int id)
        {
            var movie = await _repo.GetByIdAsync(id);
            if (movie == null) return NotFound();
            return Ok(_mapper.Map<MovieDto>(movie));
        }

        [HttpPost]
        public async Task<ActionResult<MovieDto>> Create(CreateMovieDto dto)
        {
            var movie = _mapper.Map<Movie>(dto);
            var added = await _repo.AddAsync(movie);
            return CreatedAtAction(nameof(Get), new { id = added.Id }, _mapper.Map<MovieDto>(added));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateMovieDto dto)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return NotFound();

            _mapper.Map(dto, existing);
            await _repo.UpdateAsync(existing);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _repo.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
