using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreTutorial.Models
{
    public class Pelicula
    {
        [Key]
        public string Titulo { get; set; }
        public string Actor { get; set; }
        public int? Duracion { get; set; }
        public int? Cantidad { get; set; }
    }
}
