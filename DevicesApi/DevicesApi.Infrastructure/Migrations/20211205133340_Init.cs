using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace DevicesApi.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RandomEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandomEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RandomEntities",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(432), null, new DateTime(2021, 12, 5, 14, 33, 40, 416, DateTimeKind.Local).AddTicks(877), "SYSTEM", "None", new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(420), "SYSTEM", "Random1" });

            migrationBuilder.InsertData(
                table: "RandomEntities",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(1569), null, new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(1558), "SYSTEM", "None", new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(1567), "SYSTEM", "Random2" });

            migrationBuilder.InsertData(
                table: "RandomEntities",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(1574), null, new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(1572), "SYSTEM", "None", new DateTime(2021, 12, 5, 14, 33, 40, 418, DateTimeKind.Local).AddTicks(1573), "SYSTEM", "Random3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RandomEntities");
        }
    }
}
