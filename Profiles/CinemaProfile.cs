using AutoMapper;
using FilmesAPI.Data.dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Profiles
{

    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
