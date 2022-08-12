using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.models
{
    public class tarea
    {
        [Key]
        public Guid tareaId { get; set; }

        [ForeignKey("categoriaId")]
        public Guid categoriaId { get; set; }

        [Required]
        [MaxLength(200)]
        public string titulo { get; set; }

        public string descripcion { get; set; }
        public prioridad prioridadTarea { get; set; }
        public DateTime fechaCreacion { get; set; }
        public virtual categoria categoria { get; set; }

        [NotMapped]
        public string resumen { get; set; }

    }

    public enum prioridad
    {
        baja,
        media,
        alta
    }
}