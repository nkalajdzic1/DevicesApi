using Microsoft.AspNetCore.Http;

namespace DevicesApi.Core.Requests
{
    public class CreateDeviceFromFileRequest
    {
        public IFormFile File { get; set; } = null!;
    }
}
