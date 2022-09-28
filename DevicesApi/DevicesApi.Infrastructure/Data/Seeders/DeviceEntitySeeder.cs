using DevicesApi.Core.Entities;
using DevicesApi.Core.Enums;

namespace DevicesApi.Infrastructure.Data.Seeders
{
    public class DeviceEntitySeeder
    {
        public static readonly List<DeviceEntity> DeviceEntitySeeds = new()
        {
            new DeviceEntity() 
            { 
                Id = 1,
                DeviceId = "9RLMugEpCVSeemZ5",
                Name = "S7-150009",
                DeviceTypeId = "Beweis",
                Failsafe = false, 
                TempMin = 0, 
                TempMax = 60,
                InstallationPosition = InstallationPosition.Horizontal,
                InsertInto19InchCabinet = false,
                MotionEnable = true,
                SiplusCatalog = false,
                SimaticCatalog = false,
                RotationAxisNumber = 0,
                PositionAxisNumber = 0,
            },
            new DeviceEntity()
            {
                Id = 2,
                DeviceId = "1glmLrTZqf9YZleN",
                Name = "S7-1500",
                DeviceTypeId = "S7_1500",
                Failsafe = true,
                TempMin = 0,
                TempMax = 50,
                InstallationPosition = InstallationPosition.Vertical,
                InsertInto19InchCabinet = true,
                MotionEnable = true,
                SiplusCatalog = false,
                SimaticCatalog = false,
                RotationAxisNumber = 0,
                PositionAxisNumber = 0,
                AdvancedEnvironmentalConditions = false
            },
            new DeviceEntity()
            {
                Id = 3,
                DeviceId = "9RLMugEbCVSeemZ4",
                Name = "ET 200SP",
                DeviceTypeId = "ET200_SP",
                Failsafe = false,
                TempMin = 0,
                TempMax = 40,
                InstallationPosition = InstallationPosition.Horizontal,
                InsertInto19InchCabinet = false,
                MotionEnable = true,
                SiplusCatalog = false,
                SimaticCatalog = false,
                RotationAxisNumber = 0,
                PositionAxisNumber = 0,
                TerminalElement = true,
                AdvancedEnvironmentalConditions = false
            }
        };
    }
}
