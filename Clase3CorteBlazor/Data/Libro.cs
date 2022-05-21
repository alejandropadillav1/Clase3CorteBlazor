﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3CorteBlazor.Data
{
    public class Libro
    {
        [Key]
        public int idlibro { get; set; }
        public string titulo { get; set; }
        public string editorial { get; set; }
        public string autor { get; set; }
        public int pagina { get; set; }
        public string descripcion { get; set; }
    }
}
