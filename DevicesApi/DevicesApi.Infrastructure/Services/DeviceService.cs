using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using DevicesApi.Core.Dtos;
using DevicesApi.Core.Interfaces;
using DevicesApi.Core.Responses;
using DevicesApi.Infrastructure.Data;
using DevicesApi.Core.Classes;
using DevicesApi.Core.Entities;

namespace DevicesApi.Infrastructure.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public DeviceService(IMapper mapper, DataContext context, IHttpContextAccessor httpContext)
        {
            _mapper = mapper;
            _context = context;
            _httpContext = httpContext;
        }

        /// <summary>
        ///  Method to return list of devices from the dabase based on the filter query parameters
        /// </summary>
        /// <param name="filterDevicesDto"> Device filter dto, contains the page number, page size etc. </param>
        /// <returns> List of devices </returns>
        public async Task<Response<List<GetDeviceDto>>> Get(FilterDevicesDto filterDevicesDto)
        {
            // create builder query - main query for the list
            var query = _context.DeviceEntities.AsQueryable();
            // creat builder query for the total count
            var countQuery = _context.DeviceEntities.AsQueryable();

            // add sorting for main query
            QueryBuilder.AddSorting(ref query, filterDevicesDto.OrderBy, filterDevicesDto.Order);
            // add pagination for main query
            QueryBuilder.AddPagination(ref query, filterDevicesDto.PageNumber, filterDevicesDto.PageSize);

            // add total count to response header
            Header.AddXTotalCount(_httpContext, (await countQuery.CountAsync()).ToString());

            return new()
            {
                Data = await query.Select(x => _mapper.Map<GetDeviceDto>(x)).ToListAsync(),
                StatusCode = StatusCodes.Status200OK
            };
        }

        /// <summary>
        /// Method to return a device by id, with the full information about the device
        /// </summary>
        /// <param name="deviceId"> Id of the device </param>
        /// <returns> Device for the corresponding device id </returns>
        /// <exception cref="Exception"> Throws not found exception if an invalid id is given (item does not exist for the given id) </exception>
        public async Task<Response<GetDeviceFullInfoDto>> GetById(int deviceId)
        {
            var device = await _context.DeviceEntities.Where(x => x.Id == deviceId)
                                                      .Select(x => _mapper.Map<GetDeviceFullInfoDto>(x))
                                                      .FirstOrDefaultAsync();

            if(device == null)
            {
                return new() { StatusCode = StatusCodes.Status400BadRequest };
            }

            return new()
            {
                Data = device,
                StatusCode = StatusCodes.Status200OK
            };
        }

        /// <summary>
        /// Method to create a device
        /// </summary>
        /// <param name="createDeviceDto"> Create Device dto, containing all the properties for creating a device </param>
        /// <returns> The created device with the device id </returns>
        public async Task<Response<GetDeviceFullInfoDto>> Create(CreateDeviceDto createDeviceDto)
         {
            // map request to entity
            var device = _mapper.Map<DeviceEntity>(createDeviceDto);
             
            // add the device to db
            await _context.DeviceEntities.AddAsync(device);
            await _context.SaveChangesAsync();

            return new()
            {
                Data = _mapper.Map<GetDeviceFullInfoDto>(device),
                StatusCode = StatusCodes.Status201Created
            };
         }

        /// <summary>
        /// Method to update device by id
        /// </summary>
        /// <param name="deviceId"> Id of the given device </param>
        /// <param name="updateDeviceDto"> data to update the given device </param>
        /// <returns> The updated device </returns>
        /// <exception cref="Exception"> Throws not found exception if an invalid id is given (item does not exist for the given id) </exception>
        public async Task<Response<GetDeviceFullInfoDto>> UpdateById(int deviceId, UpdateDeviceDto updateDeviceDto)
         {
            var device = await _context.DeviceEntities.FirstOrDefaultAsync(x => x.Id == deviceId);

            if (device == null)
            {
                return new() { StatusCode = StatusCodes.Status400BadRequest };
            }

            _context.Entry(device).CurrentValues.SetValues(updateDeviceDto);
            await _context.SaveChangesAsync();

            return new()
            {
                Data = _mapper.Map<GetDeviceFullInfoDto>(device),
                StatusCode= StatusCodes.Status200OK
            };
         }

        /// <summary>
        /// Method to delete device by id
        /// </summary>
        /// <param name="deviceId"> Id of the given device </param>
        /// <returns> 204 status code if the device is deleted </returns>
        /// <exception cref="Exception"> Throws not found exception if an invalid id is given (item does not exist for the given id) </exception>
        public async Task<Response<bool>> DeleteById(int deviceId)
         {
            var device = await _context.DeviceEntities.FirstOrDefaultAsync(x => x.Id == deviceId);

            if (device == null)
            {
                return new() { StatusCode = StatusCodes.Status400BadRequest };
            }

            _context.DeviceEntities.Remove(device);
            await _context.SaveChangesAsync();

            return new() { Data = true, StatusCode= StatusCodes.Status204NoContent };
        }
    }
}
