﻿using static MandrilApi.Models.Habilidad;

namespace MandrilApi.Models
{
    public class HabilidadInsert
    {
        public string Nombre { get; set; } = string.Empty;

        public EPotencia Potencia { get; set; }
    }
}
