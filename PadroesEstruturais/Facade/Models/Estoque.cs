using System;

namespace Facade.Models
{
    public class Estoque
    {
        private int Disponivel = 200;
        public bool VerificarSeDisponivel(Pedido pedido)
        {
            if (pedido.Produto.Quantidade <= this.Disponivel) return true;

            return false;
        }

        public void EnviarProduto(Pedido pedido)
        {
            Console.WriteLine($"O produto {pedido.Produto.Nome} será entregue no endereço: {pedido.Endereco.Cep} : " +
                              $"{pedido.Endereco.Estado} : {pedido.Endereco.Cidade} : {pedido.Endereco.Rua}\n" +
                              $"até as 18h do dia {DateTime.Now.AddDays(7)}");
        }   
    }
}
