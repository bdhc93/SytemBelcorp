using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SytemBelcorp.Entities;
using SytemBelcorp.Repository;

namespace GenerarDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando base de datos");
            PedidoRepository repository = new PedidoRepository();
            //var pedido = new Pedido { MontoPedido = 123 };
            //repository.addPedido(pedido);
            repository.getAllPedido();
            Console.WriteLine("Base de datos creada...!!!");
        }
    }
}
