using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformPrfoile:Profile
    {
        public PlatformPrfoile()
        {
            //response 
            CreateMap<Platform,PlatformReadDto>();
            //request
            CreateMap<PlatformCreateDto,Platform>();    
        }
    }
}
