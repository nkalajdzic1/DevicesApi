using System.ComponentModel.DataAnnotations;

using DevicesApi.Core.Enums;

namespace DevicesApi.Core.Entities
{
    public class DeviceEntity: BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "DeviceId cannot be longer than 50 characters")]
        public string DeviceId { get; set; } = string.Empty;

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; } = String.Empty;

        [Required]
        [MaxLength(50, ErrorMessage = "DeviceTypeId cannot be longer than 50 characters")]
        public string DeviceTypeId { get; set; } = String.Empty;

        [Required]
        public bool Failsafe { get; set; }

        [Required]
        public double TempMin { get; set; }

        [Required]
        public double TempMax { get; set; }

        [Required]
        public InstallationPosition InstallationPosition { get; set; }

        [Required]
        public bool InsertInto19InchCabinet { get; set; }

        [Required]
        public bool MotionEnable { get; set; }

        [Required]
        public bool SiplusCatalog { get; set; }

        [Required]
        public bool SimaticCatalog { get; set; }

        [Required]
        public double RotationAxisNumber { get; set; }

        [Required]
        public double PositionAxisNumber { get; set; }

        public bool? TerminalElement { get; set; }

        public bool? AdvancedEnvironmentalConditions { get; set; }
    }
}