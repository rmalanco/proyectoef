using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8281), new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8297), new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8304), new DateTime(2022, 9, 3, 17, 32, 58, 257, DateTimeKind.Local).AddTicks(8302) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2148), new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2155), new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2162), new DateTime(2022, 8, 15, 18, 11, 13, 356, DateTimeKind.Local).AddTicks(2160) });
        }
    }
}
