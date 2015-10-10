using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository
{
    public class PedidoRepository : MasterRepository, IPedidoRepository
    {
        public void addPedido(Pedido pedido)
        {
            Context.Pedidos.Add(pedido);
            Context.SaveChanges();
        }

        public List<Pedido> getAllPedido()
        {
            var query = from p in Context.Pedidos
                        select p;
            return query.ToList();
            //return new List<Pedido>();
        }

        public List<Pedido> getAllPedidoByCriterio(string criterio)
        {
            throw new NotImplementedException();
        }

        public Pedido getFromPedidoById(int id)
        {
            throw new NotImplementedException();
        }

        public void removePedido(int id)
        {
            throw new NotImplementedException();
        }

        public void upDatePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
