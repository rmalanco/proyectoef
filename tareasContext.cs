using Microsoft.EntityFrameworkCore;
using proyectoef.models;

namespace proyectoef;

public class tareasContext : DbContext // sirve para crear la base de datos en memoria
{
    public DbSet<categoria> Categorias { get; set; } // indica que es una tabla
    public DbSet<tarea> Tareas { get; set; } // indica que es una tabla
    public tareasContext(DbContextOptions<tareasContext> options) : base(options) { } // constructor
    protected override void OnModelCreating(ModelBuilder modelBuilder) // sirve para crear los campos de la base de datos
    {
        List<categoria> categoriasInit = new List<categoria>();

        categoriasInit.Add(new categoria { categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), nombre = "Actividades pendientes", descripcion = "Tareas pendientes de realizar", peso = 1 });
        categoriasInit.Add(new categoria { categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a83"), nombre = "Actividades realizadas", descripcion = "Tareas realizadas", peso = 2 });
        categoriasInit.Add(new categoria { categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a84"), nombre = "Actividades en progreso", descripcion = "Tareas en progreso", peso = 3 });
        categoriasInit.Add(new categoria { categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a85"), nombre = "Actividades canceladas", descripcion = "Tareas canceladas", peso = 4 });
        categoriasInit.Add(new categoria { categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a86"), nombre = "Actividades finalizadas", descripcion = "Tareas finalizadas", peso = 5 });
        categoriasInit.Add(new categoria { categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a87"), nombre = "Actividades eliminadas", descripcion = "Tareas eliminadas", peso = 6 });


        modelBuilder.Entity<categoria>(categoria =>
        {
            // indica que es una tabla
            categoria.ToTable("categoria");
            // indica que es la clave primaria
            categoria.HasKey(c => c.categoriaId);
            // indica que es un campo obligatorio y su tamaño máximo es 150
            categoria.Property(c => c.nombre).IsRequired().HasMaxLength(160);
            // indica que es un campo opcional
            categoria.Property(c => c.descripcion).IsRequired(false);
            // indica que es un campo de tipo entero
            categoria.Property(c => c.peso);
            // indica que es un campo de tipo fecha
            categoria.Property(c => c.fechaCreacion).HasDefaultValueSql("getdate()");
            // indica que la base de datos tiene datos
            categoria.HasData(categoriasInit);

        });

        List<tarea> tareasInit = new List<tarea>();
        tareasInit.Add(new tarea { tareaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a87"), categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), prioridadTarea = prioridad.media, titulo = "Pago de servicios publicos", descripcion = "Pago de servicios publicos", fechaCreacion = DateTime.Now, fechaActualizacion = DateTime.Now });
        tareasInit.Add(new tarea { tareaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a88"), categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), prioridadTarea = prioridad.media, titulo = "Pago de servicios publicos", descripcion = "Pago de servicios telefono", fechaCreacion = DateTime.Now, fechaActualizacion = DateTime.Now });
        tareasInit.Add(new tarea { tareaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a89"), categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), prioridadTarea = prioridad.media, titulo = "Pago de servicios publicos", descripcion = "Pago de servicios cable", fechaCreacion = DateTime.Now, fechaActualizacion = DateTime.Now });
        tareasInit.Add(new tarea { tareaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a90"), categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), prioridadTarea = prioridad.media, titulo = "Pago de servicios publicos", descripcion = "Pago de servicios netflix", fechaCreacion = DateTime.Now, fechaActualizacion = DateTime.Now });
        tareasInit.Add(new tarea { tareaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a91"), categoriaId = Guid.Parse("b26d5280-5460-47bf-9f5b-ed2eebc69a82"), prioridadTarea = prioridad.media, titulo = "Pago de servicios publicos", descripcion = "Pago de servicios spotify", fechaCreacion = DateTime.Now, fechaActualizacion = DateTime.Now });

        modelBuilder.Entity<tarea>(tarea =>
        {
            // indica que es una tabla
            tarea.ToTable("tarea");
            // indica que es la clave primaria
            tarea.HasKey(t => t.tareaId);
            // indica que una tarea tiene una categoria y una categoria tiene muchas tareas
            tarea.HasOne(t => t.categoria).WithMany(c => c.tareas).HasForeignKey(t => t.categoriaId);
            // indica que es un campo obligatorio y su tamaño máximo es 200
            tarea.Property(t => t.titulo).IsRequired().HasMaxLength(200);
            // indica que es un campo opcional
            tarea.Property(t => t.descripcion).IsRequired(false);
            // indica que es un campo opcional
            tarea.Property(t => t.prioridadTarea);
            // indica que es un campo opcional
            tarea.Property(t => t.fechaCreacion);
            // indica que es un campo opcional
            tarea.Property(t => t.fechaActualizacion);
            // indica que no se incluirá en la respuesta
            tarea.Ignore(t => t.resumen);
            // indica que la base de datos tiene datos
            tarea.HasData(tareasInit);
        });
    }
}

// tarea.Property(t => t.prioridadTarea).HasConversion(                                        // indica que es un campo con una conversión de tipo enumerado
//     v => v.ToString(),
//     v => (prioridad)Enum.Parse(typeof(prioridad), v));
