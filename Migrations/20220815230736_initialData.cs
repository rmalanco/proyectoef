using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class initialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoria",
                columns: new[] { "categoriaId", "descripcion", "nombre", "peso" },
                values: new object[,]
                {
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), "Tareas pendientes de realizar", "Actividades pendientes", 1 },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a83"), "Tareas realizadas", "Actividades realizadas", 2 },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a84"), "Tareas en progreso", "Actividades en progreso", 3 },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a85"), "Tareas canceladas", "Actividades canceladas", 4 },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a86"), "Tareas finalizadas", "Actividades finalizadas", 5 }
                });

            migrationBuilder.InsertData(
                table: "tarea",
                columns: new[] { "tareaId", "categoriaId", "descripcion", "fechaActualizacion", "fechaCreacion", "prioridadTarea", "titulo" },
                values: new object[,]
                {
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"), new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), "Pago de servicios publicos", new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2312), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2269), 1, "Pago de servicios publicos" },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"), new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), "Pago de servicios telefono", new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2319), 1, "Pago de servicios publicos" },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"), new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), "Pago de servicios cable", new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2326), 1, "Pago de servicios publicos" },
                    { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"), new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), "Pago de servicios netflix", new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2335), new DateTime(2022, 8, 15, 18, 7, 36, 529, DateTimeKind.Local).AddTicks(2333), 1, "Pago de servicios publicos" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "categoriaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a83"));

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "categoriaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a84"));

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "categoriaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a85"));

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "categoriaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a86"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"));

            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"));

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "categoriaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"));
        }
    }
}
