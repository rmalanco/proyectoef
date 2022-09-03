using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace proyectoef.models
{
    public class categoria
    {
        //[Key]
        public Guid categoriaId { get; set; }
        //[Required]
        //[MaxLength(150)]
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int peso { get; set; }
        public DateTime fechaCreacion { get; set; }

        [JsonIgnore] // sirve para que no se muestre en el json de la respuesta de la api 
        public virtual ICollection<tarea> tareas { get; set; }
    }
}