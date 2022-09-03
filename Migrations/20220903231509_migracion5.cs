using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoef.Migrations
{
    public partial class migracion5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "categoria",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6743), new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6754), new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                columns: new[] { "fechaActualizacion", "fechaCreacion" },
                values: new object[] { new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6769), new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.InsertData(
                table: "tarea",
                columns: new[] { "tareaId", "categoriaId", "descripcion", "fechaActualizacion", "fechaCreacion", "prioridadTarea", "titulo" },
                values: new object[] { new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a91"), new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), "Pago de servicios spotify", new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6776), new DateTime(2022, 9, 3, 18, 15, 9, 493, DateTimeKind.Local).AddTicks(6774), 1, "Pago de servicios publicos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tarea",
                keyColumn: "tareaId",
                keyValue: new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a91"));

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "categoria",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

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
    }
}
