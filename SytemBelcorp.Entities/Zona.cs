using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class Zona
    {
        public Zona()
        {
            this.Secciones = new List<Seccion>();
        }
        
        public Int32 Id { get; set; }
        public String Nombre { get; set; }

        public List<Seccion> Secciones { get; set; }

        public Int32 IdConsultora { get; set; }
        public Consultora Consultora { get; set; }
    }
}
