using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using DevicesApi.Core.Classes;
using DevicesApi.Core.Dtos;
using DevicesApi.Core.Interfaces;
using DevicesApi.Core.Requests;

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
            _logger.LogInformation(message: $"{nameof(DevicesController)}.{nameof(DevicesController.Get)} called.");
            var res = await _deviceService.Get(_mapper.Map<FilterDevicesDto>(getDevicesRequest));

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> GetById([FromRoute] int id)
        {
            _logger.LogInformation(message: $"{nameof(DevicesController)}.{nameof(DevicesController.GetById)} called.");
            var res = await _deviceService.GetById(id);

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> Create([FromBody] CreateDeviceRequest createDeviceRequest)
        {
            _logger.LogInformation(message: $"{nameof(DevicesController)}.{nameof(DevicesController.Create)} called.");
            var res = await _deviceService.Create(_mapper.Map<CreateDeviceDto>(createDeviceRequest));

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpPost("upload")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> CreateFromFile([FromForm] CreateDeviceFromFileRequest createDeviceFromFileRequest)
        {
            _logger.LogInformation(message: $"{nameof(DevicesController)}.{nameof(DevicesController.CreateFromFile)} called.");

            // read file and map data
            var device = JsonConverter.ReaFileToJson<CreateDeviceFileDto>(createDeviceFromFileRequest.File);
            // call service
            var res = await _deviceService.Create(_mapper.Map<CreateDeviceDto>(device));

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDeviceFullInfoDto>> UpdateById([FromRoute] int id, [FromBody] UpdateDeviceRequest updateDeviceRequest)
        {
            _logger.LogInformation(message: $"{nameof(DevicesController)}.{nameof(DevicesController.UpdateById)} called.");
            var res = await _deviceService.UpdateById(id, _mapper.Map<UpdateDeviceDto>(updateDeviceRequest));

            return StatusCode(res.StatusCode, res.Data);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<bool>> DeleteById([FromRoute] int id)
        {
            _logger.LogInformation(message: $"{nameof(DevicesController)}.{nameof(DevicesController.DeleteById)} called.");
            var res = await _deviceService.DeleteById(id);

            return StatusCode(res.StatusCode, res.Data);
        }
    }
}