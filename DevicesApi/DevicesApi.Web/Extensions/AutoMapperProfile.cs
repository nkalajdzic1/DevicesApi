using AutoMapper;
using DevicesApi.Core.Dtos;
using DevicesApi.Core.Entities;
using DevicesApi.Core.Requests;

namespace DevicesApi.Web.Extensions
{
    public class AutoMapperProfile : Profile
    {
        // all automapping is handled here 
        public AutoMapperProfile()
        {
            // create the automapping for dtos and entities here
            CreateMap<DeviceEntity, GetDeviceDto>();
            CreateMap<DeviceEntity, GetDeviceFullInfoDto>();
            
            CreateMap<GetDevicesRequest, FilterDevicesDto>();
            CreateMap<CreateDeviceRequest, CreateDeviceDto>();
            CreateMap<UpdateDeviceRequest, UpdateDeviceDto>();

            CreateMap<CreateDeviceDto, DeviceEntity>();
        }
    }
}
