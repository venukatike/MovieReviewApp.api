using AutoMapper;
using MovieReviewApp.api.DTOs;
using MovieReviewApp.api.Models;

namespace MovieReviewApp.api.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<CreateMovieDto, Movie>();
        }
    }
}
