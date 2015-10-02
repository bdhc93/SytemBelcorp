using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class TipoConsultora
    {
        public TipoConsultora()
        {
            this.Consultoras = new List<Consultora>();
        }

        public Int32 Id { get; set; }
        public String Decimal { get; set; }
        public String Descripcion { get; set; }

        public List<Consultora> Consultoras { get; set; }
    }
}
