using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
  string email = Console.ReadLine(); 
  string nomeUsuario = Console.ReadLine();
  string senha = Console.ReadLine();
    

// Obtém o email e nome do usuário a partir da entrada do console
    string registroEmail = email;
    string registroNome = nomeUsuario;
   
// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");
    }
}