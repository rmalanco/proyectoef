using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fechaCreacion",
                table: "categoria",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaCreacion",
                table: "categoria");

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
    }
}
