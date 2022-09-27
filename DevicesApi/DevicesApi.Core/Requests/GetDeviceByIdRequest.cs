using System.ComponentModel.DataAnnotations;

namespace DevicesApi.Core.Requests
{
    public class GetDeviceByIdRequest
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
    }
}
