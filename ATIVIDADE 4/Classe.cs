using System;

public class VagaEstacionamento
{
    private int numeroVaga;
    private bool ocupada;
    private string tipoVeiculo;

    public int NumeroVaga
    {
        get { return numeroVaga; }
    }

    public bool Ocupada
    {
        get { return ocupada; }
        private set { ocupada = value; }
    }

    public string TipoVeiculo
    {
        get { return tipoVeiculo; }
        private set
        {
            if (value == "Carro" || value == "Moto" || value == "Caminhão")
            {
                tipoVeiculo = value;
            }
            else
            {
                Console.WriteLine("Tipo de veículo inválido. Use: Carro, Moto ou Caminhão.");
            }
        }
    }

    public VagaEstacionamento(int numeroVaga, string tipoVeiculo)
    {
        this.numeroVaga = numeroVaga;
        this.TipoVeiculo = tipoVeiculo;
        this.Ocupada = false;
    }

    public void OcuparVaga()
    {
        Ocupada = true;
        Console.WriteLine("Vaga ocupada.");
    }

    public void LiberarVaga()
    {
        Ocupada = false;
        Console.WriteLine("Vaga liberada.");
    }

    public void AlterarTipoVeiculo(string novoTipo)
    {
        if (Ocupada)
        {
            Console.WriteLine("Não é possível alterar o tipo de veículo com a vaga ocupada.");
        }
        else
        {
            TipoVeiculo = novoTipo;
        }
    }

    public void ExibirInformacoes()
    {
        string status = Ocupada ? "Ocupada" : "Livre";
        Console.WriteLine($"Vaga nº {NumeroVaga}");
        Console.WriteLine($"Tipo de veículo permitido: {TipoVeiculo}");
        Console.WriteLine($"Status: {status}");
    }
}
