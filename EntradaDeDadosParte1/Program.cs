// nessa atual versão do C#, não é obrigatório digitar comandos como "using", "void main", são comandos que estão em uso automaticamente

string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

string[] v = Console.ReadLine().Split(' ');//função Split para recortar e redistribuir separadamente a variável
string a = v[0];
string b = v[1];
string c = v[2];

Console.WriteLine("\nVocê digitou: ");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);