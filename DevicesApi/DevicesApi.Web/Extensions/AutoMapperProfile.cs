using AutoMapper;

namespace DevicesApi.Web.Extensions
{
    public class AutoMapperProfile : Profile
    {
        // all automapping is handled here 
        public AutoMapperProfile()
        {
            // create the automapping for dtos and entities here
            // CreateMap<SomeEntity, SomeEntityDto>();
        }
    }
}
