using System;
namespace Crinado_jogador_futebol.Models;
class Program
{
    static void Main()
    {
        Console.WriteLine("___________________________________________________________");
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string posicao = Console.ReadLine();
        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

        Console.WriteLine("___________________________________________________________");
        jogador.ExibirDadosJogador();
        Console.WriteLine("___________________________________________________________");
    }
}