using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WatchTogetherAPI.Dtos.Genre;
using WatchTogetherAPI.Dtos.Movie;
using WatchTogetherAPI.Models;

namespace WatchTogetherAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, GetMovieDto>();
            CreateMap<Genre, GetGenreDto>();
            CreateMap<Movie, GetMovieDto>()
                .ForMember(dto => dto.Genres, m => m.MapFrom(m => m.Movies_Genres.Select(mg => mg.Genre)));
        }
    }
}
