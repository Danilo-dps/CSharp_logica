using System.Globalization;
using Tuplas.Models;


Pessoa p1 = new Pessoa("Danilo", "Silva");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");


















/*LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// O underline "_" é usado para descarte de informação

if(sucesso)
{
    //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}*/




/*(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Danilo", "Silva", 1.91M);

ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Danilo", "Silva", 1.91M);
var outroExemploTuplaCreate = Tuple.Create(1, "Danilo", "Silva", 1.91M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");*/
