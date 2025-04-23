using System;

namespace ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("ESTOQUE");
                Console.WriteLine("1. Cadastrar produto");
                Console.WriteLine("2. Adicionar ao estoque");
                Console.WriteLine("3. Remover do estoque");
                Console.WriteLine("4. Exibir valor total em estoque");
                Console.WriteLine("5. Exibir informações do produto");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do produto: ");
                        produto.Nome = Console.ReadLine();

                        Console.Write("Preço: ");
                        produto.Preco = decimal.Parse(Console.ReadLine());

                        Console.Write("Quantidade inicial: ");
                        produto.Quantidade = int.Parse(Console.ReadLine());
                        break;

                    case "2":
                        Console.Write("Quantidade a adicionar: ");
                        int qtdAdd = int.Parse(Console.ReadLine());
                        produto.AdicionarEstoque(qtdAdd);
                        break;

                    case "3":
                        Console.Write("Quantidade a remover: ");
                        int qtdRemover = int.Parse(Console.ReadLine());
                        produto.RemoverEstoque(qtdRemover);
                        break;

                    case "4":
                        Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotalEmEstoque():F2}");
                        break;

                    case "5":
                        Console.WriteLine($"Produto: {produto.Nome}");
                        Console.WriteLine($"Preço: R$ {produto.Preco:F2}");
                        Console.WriteLine($"Quantidade em estoque: {produto.QuantidadeTotal}");
                        Console.WriteLine($"Valor total: R$ {produto.ValorTotalEmEstoque():F2}");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
