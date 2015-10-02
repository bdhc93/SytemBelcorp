using System;
using System.Collections.Generic;

namespace SytemBelcorp.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            this.Visitas = new List<Visita>();
        }

        public Int32 Id { get; set; }
        public Int32 MontoPedido { get; set; }

        public List<Visita> Visitas { get; set; }
    }
}
