using API.Data.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>()
                .ForMember(m => m.PhotoUrl,
                    opt => opt.MapFrom(u => u.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(m => m.Age,
                    opt => opt.MapFrom(u => u.DateOfBirth.CalculateAge()));

            CreateMap<Photo, PhotoDTO>();
        }
    }
}
