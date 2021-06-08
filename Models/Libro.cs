using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreTutorial.Models
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public double? Precio { get; set; }
    }
}
