using System;

class Program
{
    static void Main(string[] args)
    {
        VagaEstacionamento vaga = new VagaEstacionamento(101, "Carro");
        vaga.OcuparVaga();
        vaga.AlterarTipoVeiculo("Moto");
        vaga.LiberarVaga();
        vaga.AlterarTipoVeiculo("Moto");
        Console.WriteLine();
        vaga.ExibirInformacoes();
    }
}
