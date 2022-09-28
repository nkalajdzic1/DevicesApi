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
        private readonly IMapper _mapper;

        public DevicesController(IDeviceService deviceService, IMapper mapper, ILogger<DevicesController> logger)
        {
            _deviceService = deviceService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<GetDeviceDto>>> Get([FromQuery] GetDevicesRequest getDevicesRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.Get)} called.");
            var res = await _deviceService.Get(_mapper.Map<FilterDevicesDto>(getDevicesRequest));
            _logger.LogDebug(message: $"{nameof(DevicesController.Get)} finished.");

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> GetById([FromRoute] int id)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.GetById)} called with Id {id}.");
            var res = await _deviceService.GetById(id);
            _logger.LogDebug(message: $"{nameof(DevicesController.GetById)} call with Id {id} finished.");

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> Create([FromBody] CreateDeviceRequest createDeviceRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.Create)} called.");
            var res = await _deviceService.Create(_mapper.Map<CreateDeviceDto>(createDeviceRequest));
            _logger.LogDebug(message: $"{nameof(DevicesController.Create)} finished.");

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> UpdateById([FromRoute] int id, [FromBody] UpdateDeviceRequest updateDeviceRequest)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.UpdateById)} called with device Id {id}.");
            var res = await _deviceService.UpdateById(id, _mapper.Map<UpdateDeviceDto>(updateDeviceRequest));
            _logger.LogDebug(message: $"{nameof(DevicesController.UpdateById)} call with device Id {id} finished.");

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> DeleteById([FromRoute] int id)
        {
            _logger.LogDebug(message: $"{nameof(DevicesController.DeleteById)} called with device Id {id}.");
            var res = await _deviceService.DeleteById(id);
            _logger.LogDebug(message: $"{nameof(DevicesController.DeleteById)} call with device Id {id} finished.");

            return StatusCode(res.StatusCode, res.Data);
        }
    }
}