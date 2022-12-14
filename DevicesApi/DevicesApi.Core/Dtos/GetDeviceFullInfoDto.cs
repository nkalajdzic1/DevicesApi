using DevicesApi.Core.Models;

namespace DevicesApi.Core.Dtos
{
    public class GetDeviceFullInfoDto: DeviceBaseModel
    {
        public int Id { get; set; }

        public string InstallationPosition { get; set; } =  string.Empty;
    }
}
