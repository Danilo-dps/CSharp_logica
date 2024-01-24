using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int tamanhoLista = int.Parse(Console.ReadLine());

        List<string> listaClientes = new List<string>();

        for (int i = 1; i <= tamanhoLista; i++)
        {
            //Solicite ao usuário o nome do cliente e adiciona à lista
            string nomeCliente = Console.ReadLine();
            listaClientes.Add(nomeCliente);
        }

        Console.WriteLine("\nLista de Contatos:");

        for (int i = 0; i < listaClientes.Count; i++)
        {
            //Exibe o número do cliente na lista e o nome do cliente
            Console.WriteLine($"{i+1}. {listaClientes[i]}");
        }
    }
}