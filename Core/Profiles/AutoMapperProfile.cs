using AgrixemAPI.Core.DTOs.Cows;
using AgrixemAPI.Core.Models.Production.Cattle;
using AutoMapper;

namespace AgrixemAPI.Core.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Ignore missing values for services
            CreateMap<CattleDTO, Cattle>().ReverseMap();
        }
    }
}
