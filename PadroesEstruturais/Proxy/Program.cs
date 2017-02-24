using Ninject;
using PadroesEstruturais.Interface;
using PadroesEstruturais.Models;
using System;
using System.Threading;

namespace Proxy
{
    class Program
    {
        private static IKernel kernel = new StandardKernel();

        static void Main(string[] args)
        {
            
            AddBiding();

            var contaPadrao = kernel.Get<IConta>();

            var proxy = new ContaProxy(contaPadrao);

            proxy.Deposita(100);

            Thread.Sleep(300);

            proxy.Saca(50);

            Console.WriteLine("Verificando saldo....");
            Thread.Sleep(500);

            Console.WriteLine("Saldo R$: {0}",proxy.Saldo);
            
            Console.ReadKey();

        }

        private static void AddBiding()
        {
            kernel.Bind<IConta>().To<ContaPadrao>();
        }
    }
}
