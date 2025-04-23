namespace ProjetoCalculadora
{
    public class Calculo
    {]
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public double Resultado { get; private set; }

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }

        public double RetornarMaior()
        {
            return (ValorA > ValorB) ? ValorA : ValorB;
        }

        public void SomarGeral(double outroValor)
        {
            Resultado = ValorA + ValorB + outroValor;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine($"Resultado: {Resultado}");
        }
    }
}
