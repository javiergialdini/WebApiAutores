using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.Validaciones;

namespace WebApiAutores.DTOs
{
    public class LibroDTO
    {
        /// <summary>
        /// Id del libro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// titulo del libro
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Fecha Publicacion
        /// </summary>
        public DateTime FechaPublicacion { get; set; }
    }
}
