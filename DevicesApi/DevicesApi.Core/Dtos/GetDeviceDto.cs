namespace DevicesApi.Core.Dtos
{
    public class GetDeviceDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool FailSafe { get; set; }
        public string DeviceTypeId { get; set; } = string.Empty;
    }
}
