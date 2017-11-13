using System;

namespace Facade.Models
{
    public class Produto
    {
        public Guid ProdutoId        { get; private set; }  
        public string   Nome         { get; private set; }
        public string   Descricao    { get; private set; }
        public decimal  Preco        { get; private set; }
        public DateTime DataValidade { get; private set; }
        public int Quantidade        { get; private set; }

        public Produto(Guid produtoId, string nome, string descricao, decimal preco, DateTime dataValidade, int quantidade)
        {
            this.ProdutoId = produtoId;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
            this.DataValidade = dataValidade;
            this.Quantidade = quantidade;
        }
        
        public bool DataValidadeEhValida()
        {
            if (DataValidade != null && DataValidade != DateTime.MinValue && DataValidade != DateTime.Now) return true;

            return false;
        }

        public bool QuantidadeEhValida()
        {
            if (this.Quantidade > 0) return true;

            return false;
        }
    }
}
