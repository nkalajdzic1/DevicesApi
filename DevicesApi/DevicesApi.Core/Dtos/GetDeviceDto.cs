namespace DevicesApi.Core.Dtos
{
    public class GetDeviceDto
    {
        public string Name { get; set; } = string.Empty;
        public bool FailSafe { get; set; }
        public string DeviceTypeId { get; set; } = string.Empty;
    }
}
