using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class changedescriptionoptionalfalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2312), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2335), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2333) });
        }
    }
}
