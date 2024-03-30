using System;

class Program
{
    static void Main()
    {

        // TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:


        // Obtém o titulo e a descricao a partir da entrada do console  
        string titulo = Console.ReadLine();
        string descricao = Console.ReadLine();

        // TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
        int maxTamanho = 50;
        if(descricao.Length > maxTamanho)
        {
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }
        else
        {
        // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
        string dataVencimento = Console.ReadLine();
        // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
        Console.WriteLine($"{descricao} ate {dataVencimento}");
        }  
    }
}
