
using PadroesEstruturais.Interface;
using System;
using System.Threading;

/* Objetivo: Controlar as chamadas a um objeto 
   através de outro objeto de mesma interface.
*/
namespace PadroesEstruturais.Models
{
    public class ContaProxy : IConta
    {
        public double Saldo { get; set; }
        
        private readonly IConta _Conta;

        public ContaProxy(IConta conta)
        {
            _Conta = conta;
        }

        public void Deposita(double valor)
        {
            Console.WriteLine("Efetuando o depósito de R$ " + valor + " ... ");
            Thread.Sleep(300);
            this._Conta.Deposita(valor);
            Console.WriteLine("Depósito de R$ " + valor + " efetuado...");

            Saldo += valor;
        }

        public void Saca(double valor)
        {
            Console.WriteLine("Sacando o valor de  R$ " + valor + " ... ");
            this._Conta.Saca(valor);
            Thread.Sleep(300);         
            Console.WriteLine("Saque de R$ " + valor + " efetuado...");

            Saldo -= valor;
        }
    }
}
