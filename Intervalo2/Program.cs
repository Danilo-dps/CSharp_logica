

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());
int cont = 0;
int count = 0;

for(int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    if(10 < x && x < 20)
    {
        cont++;
    }
    else
    {
        count++;
    }
}
Console.WriteLine(cont + " in");
Console.WriteLine(count + " out");


