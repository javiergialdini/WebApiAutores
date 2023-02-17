using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 250)]
        public string nombre { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }

    }
}
