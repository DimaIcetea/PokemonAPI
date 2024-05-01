using AutoMapper;
using Pokemon.Models;
using PokemonReview.Dto;

namespace PokemonReview.Helper
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon.Models.Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
