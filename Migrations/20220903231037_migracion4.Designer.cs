﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoef;

#nullable disable

namespace proyectoef.Migrations
{
    [DbContext(typeof(tareasContext))]
    [Migration("20220903231037_migracion4")]
    partial class migracion4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proyectoef.models.categoria", b =>
                {
                    b.Property<Guid>("categoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.HasKey("categoriaId");

                    b.ToTable("categoria", (string)null);

                    b.HasData(
                        new
                        {
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"),
                            descripcion = "Tareas pendientes de realizar",
                            fechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            nombre = "Actividades pendientes",
                            peso = 1
                        },
                        new
                        {
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a83"),
                            descripcion = "Tareas realizadas",
                            fechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            nombre = "Actividades realizadas",
                            peso = 2
                        },
                        new
                        {
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a84"),
                            descripcion = "Tareas en progreso",
                            fechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            nombre = "Actividades en progreso",
                            peso = 3
                        },
                        new
                        {
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a85"),
                            descripcion = "Tareas canceladas",
                            fechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            nombre = "Actividades canceladas",
                            peso = 4
                        },
                        new
                        {
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a86"),
                            descripcion = "Tareas finalizadas",
                            fechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            nombre = "Actividades finalizadas",
                            peso = 5
                        },
                        new
                        {
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                            descripcion = "Tareas eliminadas",
                            fechaCreacion = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            nombre = "Actividades eliminadas",
                            peso = 6
                        });
                });

            modelBuilder.Entity("proyectoef.models.tarea", b =>
                {
                    b.Property<Guid>("tareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("categoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("prioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("tareaId");

                    b.HasIndex("categoriaId");

                    b.ToTable("tarea", (string)null);

                    b.HasData(
                        new
                        {
                            tareaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a87"),
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"),
                            descripcion = "Pago de servicios publicos",
                            fechaActualizacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3173),
                            fechaCreacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3115),
                            prioridadTarea = 1,
                            titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            tareaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a88"),
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"),
                            descripcion = "Pago de servicios telefono",
                            fechaActualizacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3183),
                            fechaCreacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3181),
                            prioridadTarea = 1,
                            titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            tareaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a89"),
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"),
                            descripcion = "Pago de servicios cable",
                            fechaActualizacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3191),
                            fechaCreacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3189),
                            prioridadTarea = 1,
                            titulo = "Pago de servicios publicos"
                        },
                        new
                        {
                            tareaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a90"),
                            categoriaId = new Guid("b26d5280-5460-47bf-9f5b-ed2eebc69a82"),
                            descripcion = "Pago de servicios netflix",
                            fechaActualizacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3199),
                            fechaCreacion = new DateTime(2022, 9, 3, 18, 10, 36, 835, DateTimeKind.Local).AddTicks(3197),
                            prioridadTarea = 1,
                            titulo = "Pago de servicios publicos"
                        });
                });

            modelBuilder.Entity("proyectoef.models.tarea", b =>
                {
                    b.HasOne("proyectoef.models.categoria", "categoria")
                        .WithMany("tareas")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("proyectoef.models.categoria", b =>
                {
                    b.Navigation("tareas");
                });
#pragma warning restore 612, 618
        }
    }
}