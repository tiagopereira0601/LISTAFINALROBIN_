using System;

namespace ProjetoCalculadora
{
    public class Calculadora
    {
        private Calculo calculo = new Calculo();

        public void ExecutarCalculadora()
        {
            LerValores();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Maior valor");
                Console.WriteLine("5 - Somar com outro valor");
                Console.WriteLine("6 - Imprimir último resultado");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        calculo.CalcularSoma();
                        calculo.ImprimirResultado();
                        break;

                    case "2":
                        calculo.CalcularSubtracao();
                        calculo.ImprimirResultado();
                        break;

                    case "3":
                        calculo.CalcularMultiplicacao();
                        calculo.ImprimirResultado();
                        break;

                    case "4":
                        Console.WriteLine($"Maior valor: {calculo.RetornarMaior()}");
                        break;

                    case "5":
                        Console.Write("Digite um valor extra para somar com ValorA e ValorB: ");
                        double valorExtra = double.Parse(Console.ReadLine());
                        calculo.SomarGeral(valorExtra);
                        calculo.ImprimirResultado();
                        break;

                    case "6":
                        calculo.ImprimirResultado();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void LerValores()
        {
            Console.Write("Digite o valor A: ");
            calculo.ValorA = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            calculo.ValorB = double.Parse(Console.ReadLine());
        }
    }
}
