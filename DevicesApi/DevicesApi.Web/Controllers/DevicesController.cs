using AutoMapper;
using DevicesApi.Core.Interfaces;
using DevicesApi.Core.Requests;
using DevicesApi.Core.Responses;
using Microsoft.AspNetCore.Mvc;

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
        public Response<string> Get([FromQuery] GetDevicesRequest getDevicesRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.Get)} called.");
            return new Response<string> { Data = $"Page number: {getDevicesRequest.PageNumber}" };
        }


        [HttpGet("{Id}")]
        public Response<string> GetById([FromRoute] GetDeviceByIdRequest getDeviceByIdRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.Get)} called.");
            return new Response<string> { Data = $"Hello {getDeviceByIdRequest.Id}" };
        }
    }
}