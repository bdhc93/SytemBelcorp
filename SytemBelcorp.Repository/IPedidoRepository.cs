using System;
using System.Collections.Generic;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository
{
    public interface IPedidoRepository
    {
        List<Pedido> getAllPedido();
        List<Pedido> getAllPedidoByCriterio(string criterio);
        Pedido getFromPedidoById(int id);
        void addPedido(Pedido pedido);
        void upDatePedido(Pedido pedido);
        void removePedido(Int32 id);
    }
}
