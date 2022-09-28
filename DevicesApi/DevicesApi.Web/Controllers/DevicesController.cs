using AutoMapper;
using DevicesApi.Core.Dtos;
using DevicesApi.Core.Interfaces;
using DevicesApi.Core.Requests;
using DevicesApi.Core.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DevicesApi.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DevicesController : ControllerBase
    {
        private readonly ILogger<DevicesController> _logger;
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService, IMapper mapper, ILogger<DevicesController> logger)
        {
            _deviceService = deviceService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<Response<List<GetDeviceDto>>> Get([FromQuery] GetDevicesRequest getDevicesRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.Get)} called.");
           
            return await _deviceService.Get(getDevicesRequest);
        }


        [HttpGet("{id}")]
        public async Task<Response<GetDeviceFullInfoDto>> GetById([FromRoute] int id)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.GetById)} called with Id {id}.");
            
            return await _deviceService.GetById(id);
        }

        [HttpPost]
        public async Task<Response<GetDeviceFullInfoDto>> Create([FromBody] CreateDeviceRequest createDeviceRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.Create)} called.");
            
            return await _deviceService.Create(createDeviceRequest);
        }

        [HttpPut("{id}")]
        public async Task<Response<GetDeviceFullInfoDto>> UpdateById([FromRoute] int id, [FromBody] UpdateDeviceRequest updateDeviceRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.UpdateById)} called with device Id {id}.");
            
            return await _deviceService.UpdateById(id, updateDeviceRequest);
        }

        [HttpDelete("{id}")]
        public async Task<HttpStatusCode> DeleteById([FromRoute] int id)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.DeleteById)} called with device Id {id}.");

            var result = await _deviceService.DeleteById(id);

            return result.Data ? HttpStatusCode.NoContent : HttpStatusCode.BadRequest;
        }
    }
}