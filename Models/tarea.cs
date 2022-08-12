using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.models
{
    public class tarea
    {
        [Key] // sirve para indicar que es la clave primaria
        public Guid tareaId { get; set; }

        [ForeignKey("categoriaId")]
        public Guid categoriaId { get; set; }

        [Required] // indica que es un campo obligatorio
        [MaxLength(200)] // indica el tamaño máximo del campo
        public string titulo { get; set; }

        public string descripcion { get; set; }
        public prioridad prioridadTarea { get; set; }
        public DateTime fechaCreacion { get; set; }
        public virtual categoria categoria { get; set; }

        [NotMapped]
        public string resumen { get; set; }

        //[ComplexType] // indica que es un tipo complejo
        //[ConcurrencyCheck] // indica que se debe verificar la concurrencia, es decir, que no se puede modificar una tarea si ya ha sido modificada por otra persona
        //[Timestamp] // sirve para indicar que es un campo de tipo timestamp para la concurrencia
        //[Table] // sirve para indicar que es una tabla
        //[Column] // sirve para indicar que es una columna
        //[DatabaseGenerated] // indica que se genera automáticamente por la base de datos
        //[Index] // sirve para indicar que es un índice en la base de datos
        //Multiple-Column Indexes ejemplo:
        //[Index("IX_tarea_titulo_descripcion", 1, IsUnique = true)] 
        /* indica que es un índice único con dos columnas y la primera columna es la clave primaria y la segunda es la columna titulo o descripcion */
        //[InverseProperty] // sirve para indicar que una propiedad es la inversa de otra propiedad 

        /* Resumen de DataAnnotations: 
         * [Key] -> indica que es la clave primaria
         * [Required] -> indica que es un campo obligatorio
         * [MaxLength] -> indica el tamaño máximo del campo
         * [MinLength] -> indica el tamaño mínimo del campo
         * [StringLength] -> indica el tamaño máximo y mínimo del campo
         * [RegularExpression] -> indica que el campo debe tener un formato especifico
         * [Range] -> indica que el campo debe tener un valor entre un rango especifico
         * [EmailAddress] -> indica que el campo debe tener un formato de correo electrónico
         * [Phone] -> indica que el campo debe tener un formato de teléfono
         * [Url] -> indica que el campo debe tener un formato de url
         * [Compare] -> indica que el campo debe tener el mismo valor que otro campo
         * [DataType] -> indica que el campo debe tener un formato de datos especifico
         * [Column] -> indica que es una columna
         * [DatabaseGenerated] -> indica que se genera automáticamente por la base de datos
         * [Index] -> indica que es un índice en la base de datos
         * [InverseProperty] -> indica que una propiedad es la inversa de otra propiedad
         * [ComplexType] -> indica que es un tipo complejo
         * [ConcurrencyCheck] -> indica que se debe verificar la concurrencia, es decir, que no se puede modificar una tarea si ya ha sido modificada por otra persona
         * [Timestamp] -> sirve para indicar que es un campo de tipo timestamp para la concurrencia
         * [Table] -> sirve para indicar que es una tabla         
         */

    }

    public enum prioridad
    {
        baja,
        media,
        alta
    }
}