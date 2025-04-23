using System;
using System.Globalization;

namespace SistemaRH
{
    public class Funcionario
    {
        public string NomeCompleto { get; set; }
        public double Salario { get; set; }

        public virtual void ExibirDados()
        {
            string[] nomes = NomeCompleto.Split(' ');
            string sobrenome = nomes[nomes.Length - 1].ToUpper();

            Console.WriteLine($"SOBRENOME: {sobrenome}");
            Console.WriteLine($"SALÁRIO: {Salario.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}
