using System;

public class Robo
{
    private string nome;
    private string modelo;
    private int anoFabricacao;

    public Robo(string nome, string modelo, int anoFabricacao)
    {
        this.nome = nome;
        this.modelo = modelo;
        this.anoFabricacao = anoFabricacao;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome, modelo;
        int ano;

        nome = Console.ReadLine();
        modelo = Console.ReadLine();
        ano = int.Parse(Console.ReadLine());

        // Instanciando um Robo passando os valores lidos em seu construtor.
        Robo robo = new Robo(nome, modelo, ano);
  
        // Invocando o método "ExibirInformacoes".
        robo.ExibirInformacoes();
    }
}

