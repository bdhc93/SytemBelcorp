using System;
using System.Collections.Generic;


namespace SytemBelcorp.Entities
{
    public class Campaña
    {
        public Campaña()
        {
            this.Horarios = new List<Horario>();
        }

        public Int32 Id { get; set; }
        public Int32 NroCamp { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 Bonificacion { get; set; }
        public Int32 Puntos { get; set; }
        public DateTime Fecha_Reclamos { get; set; }
        public DateTime Fecha_Reunion { get; set; }

        public List<Horario> Horarios { get; set; }
    }
}
