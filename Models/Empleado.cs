using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreTutorial.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public decimal? Sueldo { get; set; }
    }
}
