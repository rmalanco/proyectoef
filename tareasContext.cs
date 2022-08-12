using Microsoft.EntityFrameworkCore;
using proyectoef.models;

namespace proyectoef;

public class tareasContext : DbContext
{
    public DbSet<categoria> categoria { get; set; }
    public DbSet<tarea> tareas { get; set; }
    protected tareasContext(DbContextOptions<tareasContext> options) : base(options) { }
}
