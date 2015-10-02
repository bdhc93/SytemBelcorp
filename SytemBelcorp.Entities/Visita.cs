using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class Visita
    {
        public Int32 Id { get; set; }
        public Int32 NroVenta { get; set; }
        public String Archivo_adjunto { get; set; }

        public Int32 IdHorario { get; set; }
        public Horario Horario { get; set; }
        public Int32 IdPedido { get; set; }
        public Pedido Pedido { get; set; }
    }
}
