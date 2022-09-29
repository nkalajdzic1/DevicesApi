using AutoMapper;

using DevicesApi.Core.Dtos;
using DevicesApi.Core.Entities;
using DevicesApi.Core.Models;
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
            CreateMap<DeviceEntity, GetDeviceFullInfoDto>().ForMember(x => x.InstallationPosition, opt => opt.MapFrom(t => t.InstallationPosition.ToString()));

            CreateMap<GetDevicesRequest, FilterDevicesDto>();
            CreateMap<CreateDeviceRequest, CreateDeviceDto>();
            CreateMap<UpdateDeviceRequest, UpdateDeviceDto>();

            CreateMap<CreateDeviceDto, DeviceEntity>();

            CreateMap<CreateDeviceFileDto, CreateDeviceDto>().ForMember(x => x.DeviceId, opt => opt.MapFrom(t => t.Id));
        }
    }
}
