using Facade.Models;
using Facade.Models.ValueObject;
using System;

namespace Facade
{
    class Program
    {
        /*
            Objetivo: Prover uma interface simplificada para a utilização de várias interfaces de um sub-sistema.
        */
        static void Main(string[] args)
        {
            Execute();
            Console.ReadKey();
        }

        private static void Execute()
        {

            var cliente = new Cliente("Teste");
            var produto    = new Produto(Guid.NewGuid(), "Óculos", "Óculos de Sol", 120M, DateTime.Now.AddDays(30), 2);          
            var transporte = new Transporte();
            var financeiro = new Financeiro();
            var estoque    = new Estoque();
            var endereco = new Endereco("06142230","xxx","xx","xx");

            var pedido = new Pedido(transporte, estoque, financeiro, endereco, produto, cliente);

            var pedidoFacade = new PedidoFacade(pedido);
            pedidoFacade.RegistraPedido();

            Console.ReadKey();
        }
    }
}
