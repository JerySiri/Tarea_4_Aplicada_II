using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreTutorial.Models
{
    public class Articulo
    {
        [Key]
        public int? Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double? Precio { get; set; }
        public int? Cantidad { get; set; }
    }
}
