using System;

class Pessoa
{
 
    public string Nome;
    public int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string GetNome()
    {
        return Nome;
    }

    public int GetIdade()
    {
        return Idade;
    }
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        int idade = Convert.ToInt32(Console.ReadLine());
        Pessoa pessoa = new Pessoa(nome, idade);
        pessoa.ExibirDados();
    }
}