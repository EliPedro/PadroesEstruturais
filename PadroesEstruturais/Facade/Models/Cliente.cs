namespace Facade.Models
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
    }
}
