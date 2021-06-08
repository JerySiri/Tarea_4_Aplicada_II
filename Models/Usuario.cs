using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreTutorial.Models
{
    public class Usuario
    {
        [Key]
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}
