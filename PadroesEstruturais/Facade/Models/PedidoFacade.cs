namespace Facade.Models
{
    public class PedidoFacade
    {
        private readonly Pedido _pedido;
        public PedidoFacade(Pedido pedido)
        {
            this._pedido = pedido;
        }

        public bool RegistraPedido()
        {
            if (!_pedido.Estoque.VerificarSeDisponivel(_pedido)) return false;

            _pedido.Estoque.EnviarProduto(_pedido);

            return true;
        }
    }
}
