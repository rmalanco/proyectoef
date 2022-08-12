using System.ComponentModel.DataAnnotations;

namespace proyectoef.models
{
    public class categoria
    {
        [Key]
        public Guid categoriaId { get; set; }

        [Required]
        [MaxLength(150)]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public virtual ICollection<tarea> tareas { get; set; }
    }
}