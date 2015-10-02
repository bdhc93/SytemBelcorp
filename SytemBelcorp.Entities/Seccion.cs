using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class Seccion
    {
        public Seccion()
        {
            this.Consultoras = new List<Consultora>();
        }

        public Int32 Id { get; set; }
        public String Nombre { get; set; }

        public List<Consultora> Consultoras { get; set; }

        public Int32 IdZona { get; set; }
        public Zona Zona { get; set; }
    }
}
