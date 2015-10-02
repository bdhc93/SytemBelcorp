using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class Horario
    {
        public Horario()
        {
            this.Visitas = new List<Visita>();
        }

        public Int32 Id { get; set; }
        public Int32 Nro_Horario { get; set; }
        public DateTime Fecha { get; set; }

        public Int32 IdTipoActividad { get; set; }
        public TipoActividad TipoActividad { get; set; }
        public Int32 IdCampaña { get; set; }
        public Campaña Campaña { get; set; }
        public Int32 IdConsultora { get; set; }
        public Consultora Consultora { get; set; }

        public List<Visita> Visitas { get; set; }
    }
}
