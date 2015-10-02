using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class Consultora
    {
        public Consultora()
        {
            this.Zonas = new List<Zona>();
        }

        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public Int32 Dni { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String SociaEmpresaria { get; set; }

        public Int32 IdTipoConsultora { get; set; }
        public TipoConsultora TipoConsultora { get; set; }

        public List<Zona> Zonas { get; set; }
    }
}
