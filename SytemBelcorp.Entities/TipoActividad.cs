using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class TipoActividad
    {
        public TipoActividad()
        {
            this.Horarios = new List<Horario>();
        }

        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }

        public List<Horario> Horarios { get; set; }
    }
}
