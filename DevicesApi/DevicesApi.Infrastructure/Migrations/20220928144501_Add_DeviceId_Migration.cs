using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevicesApi.Infrastructure.Migrations
{
    public partial class Add_DeviceId_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceId",
                table: "DeviceEntities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "DeviceEntities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArchivedAt", "CreatedAt", "DeviceId", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 16, 45, 0, 611, DateTimeKind.Local).AddTicks(6263), new DateTime(2022, 9, 28, 16, 45, 0, 609, DateTimeKind.Local).AddTicks(6335), "9RLMugEpCVSeemZ5", new DateTime(2022, 9, 28, 16, 45, 0, 611, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "DeviceEntities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArchivedAt", "CreatedAt", "DeviceId", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 16, 45, 0, 611, DateTimeKind.Local).AddTicks(9981), new DateTime(2022, 9, 28, 16, 45, 0, 611, DateTimeKind.Local).AddTicks(9968), "1glmLrTZqf9YZleN", new DateTime(2022, 9, 28, 16, 45, 0, 611, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "DeviceEntities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArchivedAt", "CreatedAt", "DeviceId", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 16, 45, 0, 612, DateTimeKind.Local).AddTicks(287), new DateTime(2022, 9, 28, 16, 45, 0, 612, DateTimeKind.Local).AddTicks(278), "9RLMugEbCVSeemZ4", new DateTime(2022, 9, 28, 16, 45, 0, 612, DateTimeKind.Local).AddTicks(286) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "DeviceEntities");

            migrationBuilder.UpdateData(
                table: "DeviceEntities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArchivedAt", "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(2360), new DateTime(2022, 9, 28, 1, 37, 25, 555, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "DeviceEntities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArchivedAt", "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3703), new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "DeviceEntities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArchivedAt", "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3836), new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3834), new DateTime(2022, 9, 28, 1, 37, 25, 556, DateTimeKind.Local).AddTicks(3835) });
        }
    }
}
