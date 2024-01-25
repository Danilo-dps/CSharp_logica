using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> clientes = new List<string>();

        while(true)
        {
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            string telefone = Console.ReadLine();

            // Registra o cliente (simulação)
            string clienteInfo = $"{nome}, {email}, {telefone}";
            clientes.Add(clienteInfo);

            string continuar = Console.ReadLine();

            //Adicionado uma condição para verificar se o usuário deseja continuar registrando mais clientes e, se desejar, continuar o loop para coletar mais informações.
            if (continuar.ToLower() != "s")
            {
                break;
            }
        }

        foreach (string cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }
}