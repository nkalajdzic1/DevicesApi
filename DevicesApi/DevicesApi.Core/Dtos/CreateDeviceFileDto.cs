using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using DevicesApi.Core.Enums;

namespace DevicesApi.Core.Dtos
{
    public class CreateDeviceFileDto
    {
        [Required]
        [JsonProperty(Required = Required.Always)]
        [MaxLength(50, ErrorMessage = "Id cannot be longer than 50 characters")]
        public string Id { get; set; } = string.Empty;

        [Required]
        [JsonProperty(Required = Required.Always)]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [JsonProperty(Required = Required.Always)]
        [MaxLength(50, ErrorMessage = "DeviceTypeId cannot be longer than 50 characters")]
        public string DeviceTypeId { get; set; } = string.Empty;

        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool Failsafe { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public double TempMin { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public double TempMax { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public InstallationPosition InstallationPosition { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool InsertInto19InchCabinet { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool MotionEnable { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool SiplusCatalog { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool SimaticCatalog { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public double RotationAxisNumber { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public double PositionAxisNumber { get; set; }

        public bool? TerminalElement { get; set; }

        public bool? AdvancedEnvironmentalConditions { get; set; }
    }
}
