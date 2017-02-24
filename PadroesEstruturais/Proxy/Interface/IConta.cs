namespace PadroesEstruturais.Interface
{
    public interface IConta
    {
        void Deposita(double valor);
        void Saca(double valor);
        double Saldo { get; set; }
    }
}
