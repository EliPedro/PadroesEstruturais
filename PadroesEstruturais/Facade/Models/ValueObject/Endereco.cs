namespace Facade.Models.ValueObject
{
    public class Endereco
    {   
        public string Cep    { get; private set; }
        public string Rua    { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
 
        public Endereco(string cep, string rua, string cidade, string estado)
        {
            this.Cep    = cep;
            this.Rua    = rua;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public bool EnderecoEhValido()
        {
            if (this.Cep.Length == 8) return true;

            return false;
        }
    }
}
