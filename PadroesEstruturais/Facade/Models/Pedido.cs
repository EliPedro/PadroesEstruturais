using Facade.Models.ValueObject;

namespace Facade.Models
{
    public class Pedido
    {
        public Transporte Transporte { get; private set; }
        public Estoque    Estoque    { get; private set; }
        public Financeiro Financeiro { get; private set; }
        public Endereco   Endereco   { get; private set; }
        public Produto    Produto    { get; private set; }
        public Cliente    Cliente    { get; private set; }   

        public Pedido(Transporte transporte, Estoque estoque, Financeiro financeiro, Endereco endereco, Produto produto, Cliente cliente)
        {
            this.Transporte = transporte;
            this.Estoque    = estoque;
            this.Financeiro = financeiro;
            this.Endereco   = endereco;
            this.Produto    = produto;
            this.Cliente    = cliente;
        }
        
        public bool PedidoEhValido()
        {
            if (this.Estoque.VerificarSeDisponivel(this)) return true;

            return false;
        }
    }
}
