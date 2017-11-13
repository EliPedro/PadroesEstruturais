using Ninject;
using PadroesEstruturais.Interface;
using PadroesEstruturais.Models;
using System;
using System.Threading;

namespace Proxy
{
    /* Objetivo: Controlar as chamadas a um objeto 
       através de outro objeto de mesma interface.
     */
    class Program
    {
        private static IKernel kernel = new StandardKernel();

        static void Main(string[] args)
        {            
            AddBiding();
            Execute();
        }

        #region AddBiding
        private static void AddBiding()
        {
            kernel.Bind<IConta>().To<ContaPadrao>();
        }
        #endregion

        #region Execute
        private static void Execute()
        {
            var contaPadrao = kernel.Get<IConta>();

            var proxy = new ContaProxy(contaPadrao);

            proxy.Deposita(100);

            Thread.Sleep(300);

            proxy.Saca(25);

            Console.WriteLine("Verificando saldo....");
            Thread.Sleep(500);

            Console.WriteLine("Saldo R$: {0}", proxy.Saldo + " .....");

            Console.ReadKey();
        }
        #endregion

    }//Fim da clase Program
}//Fim do namespace
