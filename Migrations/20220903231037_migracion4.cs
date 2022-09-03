using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class migracion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3173), new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3183), new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3199), new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3197) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(471), new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 9, 3, 18, 2, 40, 596, DateTimeKind.Local).AddTicks(476) });
        }
    }
}
