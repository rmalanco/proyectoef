using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoria",
                columns: new[] { "categoriaId", "descripcion", "nombre", "peso" },
                values: new object[] { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"), "Tareas eliminadas", "Actividades eliminadas", 6 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "categoriaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"));

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(821), new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(879), new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(886), new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(893), new DateTime(2022, 9, 3, 17, 48, 51, 977, DateTimeKind.Local).AddTicks(891) });
        }
    }
}
