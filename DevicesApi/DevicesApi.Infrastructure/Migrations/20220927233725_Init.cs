using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevicesApi.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeviceTypeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Failsafe = table.Column<bool>(type: "bit", nullable: false),
                    TempMin = table.Column<double>(type: "float", nullable: false),
                    TempMax = table.Column<double>(type: "float", nullable: false),
                    InstallationPosition = table.Column<int>(type: "int", nullable: false),
                    InsertInto19InchCabinet = table.Column<bool>(type: "bit", nullable: false),
                    MotionEnable = table.Column<bool>(type: "bit", nullable: false),
                    SiplusCatalog = table.Column<bool>(type: "bit", nullable: false),
                    SimaticCatalog = table.Column<bool>(type: "bit", nullable: false),
                    RotationAxisNumber = table.Column<double>(type: "float", nullable: false),
                    PositionAxisNumber = table.Column<double>(type: "float", nullable: false),
                    TerminalElement = table.Column<bool>(type: "bit", nullable: true),
                    AdvancedEnvironmentalConditions = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DeviceEntities",
                columns: new[] { "Id", "AdvancedEnvironmentalConditions", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "DeviceTypeId", "Failsafe", "InsertInto19InchCabinet", "InstallationPosition", "ModifiedAt", "ModifiedBy", "MotionEnable", "Name", "PositionAxisNumber", "RotationAxisNumber", "SimaticCatalog", "SiplusCatalog", "TempMax", "TempMin", "TerminalElement" },
                values: new object[] { 1, null, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(2360), null, new DateTime(2022, 9, 28, 1, 37, 25, 555, DateTimeKind.Local).AddTicks(1676), "SYSTEM", "Beweis", false, false, 0, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(2352), "SYSTEM", true, "S7-150009", 0.0, 0.0, false, false, 60.0, 0.0, null });

            migrationBuilder.InsertData(
                table: "DeviceEntities",
                columns: new[] { "Id", "AdvancedEnvironmentalConditions", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "DeviceTypeId", "Failsafe", "InsertInto19InchCabinet", "InstallationPosition", "ModifiedAt", "ModifiedBy", "MotionEnable", "Name", "PositionAxisNumber", "RotationAxisNumber", "SimaticCatalog", "SiplusCatalog", "TempMax", "TempMin", "TerminalElement" },
                values: new object[] { 2, false, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3706), null, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3703), "SYSTEM", "S7_1500", true, true, 1, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3705), "SYSTEM", true, "S7-1500", 0.0, 0.0, false, false, 50.0, 0.0, null });

            migrationBuilder.InsertData(
                table: "DeviceEntities",
                columns: new[] { "Id", "AdvancedEnvironmentalConditions", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "DeviceTypeId", "Failsafe", "InsertInto19InchCabinet", "InstallationPosition", "ModifiedAt", "ModifiedBy", "MotionEnable", "Name", "PositionAxisNumber", "RotationAxisNumber", "SimaticCatalog", "SiplusCatalog", "TempMax", "TempMin", "TerminalElement" },
                values: new object[] { 3, false, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3836), null, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3834), "SYSTEM", "ET200_SP", false, false, 0, new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3835), "SYSTEM", true, "ET 200SP", 0.0, 0.0, false, false, 40.0, 0.0, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceEntities");
        }
    }
}
