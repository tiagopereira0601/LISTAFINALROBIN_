namespace Projeto Estoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        private int quantidadeTotal;

        public int QuantidadeTotal
        {
            get { return quantidadeTotal; }
        }

        public int Quantidade
        {
            set { quantidadeTotal += value; }
        }

        public void AdicionarEstoque(int quantidade)
        {
            quantidadeTotal += quantidade;
        }

        public void RemoverEstoque(int qtde)
        {
            if (qtde <= quantidadeTotal)
            {
                quantidadeTotal -= qtde;
            }
            else
            {
                Console.WriteLine("Estoque insuficiente para remover essa quantidade.");
            }
        }

        public decimal ValorTotalEmEstoque()
        {
            return Preco * quantidadeTotal;
        }
    }
}
