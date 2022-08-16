using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoef;
using proyectoef.models;

var builder = WebApplication.CreateBuilder(args);

// Base de datos en memoria para pruebas

// builder.Services.AddDbContext<tareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
builder.Services.AddSqlServer<tareasContext>(builder.Configuration.GetConnectionString("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] tareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.MapGet("/api/tareas", async ([FromServices] tareasContext dbContext) => //sirve para obtener todas las tareas
{
    return Results.Ok(dbContext.Tareas.Include(t => t.categoria));
});

app.MapPost("/api/tareas", async ([FromServices] tareasContext dbContext, [FromBody] tarea tarea) => //sirve para crear una nueva tarea
{
    tarea.tareaId = Guid.NewGuid();
    tarea.fechaCreacion = DateTime.Now;
    await dbContext.AddAsync(tarea);
    // await dbContext.Tareas.AddAsync(tarea);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

app.MapPut("/api/tareas/{id}", async ([FromServices] tareasContext dbContext, [FromBody] tarea tarea, [FromRoute] Guid id) => //sirve para actualizar una tarea
{
    var tareaActual = dbContext.Tareas.Find(id);

    if (tareaActual != null)
    {
        tareaActual.categoriaId = tarea.categoriaId;
        tareaActual.titulo = tarea.titulo;
        tareaActual.prioridadTarea = tarea.prioridadTarea;
        tareaActual.descripcion = tarea.descripcion;

        await dbContext.SaveChangesAsync();

        return Results.Ok();
    }
    return Results.NotFound();

});

app.MapDelete("/api/tareas/{id}", async ([FromServices] tareasContext dbContext, [FromRoute] Guid id) => //sirve para eliminar una tarea
{
    var tareaActual = dbContext.Tareas.Find(id);

    if (tareaActual != null)
    {
        dbContext.Remove(tareaActual);
        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }
    return Results.NotFound();
});



app.Run();
