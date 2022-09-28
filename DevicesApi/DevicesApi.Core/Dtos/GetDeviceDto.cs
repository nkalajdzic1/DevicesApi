namespace DevicesApi.Core.Dtos
{
    public class GetDeviceDto
    {
        public string Name { get; set; } = String.Empty;
        public bool FailSafe { get; set; }
        public string DeviceTypeId { get; set; } = String.Empty;
    }
}
