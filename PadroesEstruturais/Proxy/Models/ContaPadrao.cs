using PadroesEstruturais.Interface;

namespace PadroesEstruturais.Models
{
    public class ContaPadrao : IConta
    {
        public double Saldo { get; set; }

        public void Deposita(double valor)
        {      
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
