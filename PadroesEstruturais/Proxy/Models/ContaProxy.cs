using PadroesEstruturais.Interface;
using System;
using System.Threading;


namespace PadroesEstruturais.Models
{
    public class ContaProxy : IConta
    {
        private readonly IConta _Conta;
        public double Saldo { get; set; }     
        
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
