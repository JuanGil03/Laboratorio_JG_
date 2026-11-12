using System;
using System.Collections.Generic;
using System.Text;

namespace aplicaciones_JG.entidades
{
    public class Habitaciones
    {
        public int Id { get; set; }
        public int NumPersonas { get; set; }
        public string? Ubicacion { get; set; }
        public string? TipoHabitacion { get; set; }
        public decimal PrecioNoche { get; set; }
    }
}
