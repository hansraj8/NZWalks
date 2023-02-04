using AutoMapper;

namespace NZWalksAPI.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>() //maps one model to another from domain model to dto model
            .ReverseMap();
        }

    }
    
}
