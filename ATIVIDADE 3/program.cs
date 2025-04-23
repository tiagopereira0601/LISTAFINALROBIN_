using System;
using System.Collections.Generic;

namespace SistemaRH
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE RH ===");
                Console.WriteLine("1 - Cadastrar Funcionário");
                Console.WriteLine("2 - Cadastrar Gerente");
                Console.WriteLine("3 - Listar Todos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        funcionarios.Add(CadastrarFuncionario());
                        break;

                    case "2":
                        funcionarios.Add(CadastrarGerente());
                        break;

                    case "3":
                        Console.WriteLine("=== LISTA DE FUNCIONÁRIOS ===\n");
                        foreach (var f in funcionarios)
                        {
                            f.ExibirDados();
                            Console.WriteLine("-----------------------------");
                        }
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

        static Funcionario CadastrarFuncionario()
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome completo: ");
            f.NomeCompleto = Console.ReadLine();

            Console.Write("Salário: ");
            f.Salario = double.Parse(Console.ReadLine());

            return f;
        }

        static Gerente CadastrarGerente()
        {
            Gerente g = new Gerente();

            Console.Write("Nome completo: ");
            g.NomeCompleto = Console.ReadLine();

            Console.Write("Salário: ");
            g.Salario = double.Parse(Console.ReadLine());

            Console.Write("Departamento: ");
            g.Departamento = Console.ReadLine();

            return g;
        }
    }
}
