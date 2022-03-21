using System;
using System.Collections.Generic;

#nullable disable

namespace MyEntityFramework.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
