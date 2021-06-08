using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCoreTutorial.Models
{
    public class Agenda
    {
        [Key]
        public int AgendumId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
    }
}
