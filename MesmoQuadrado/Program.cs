using System.Security.Cryptography.X509Certificates;

int n = int.Parse(Console.ReadLine());

for(int i = 0; i <= n; i++)
{
    if(i % 2 == 0 && i > 0)
    {
        Console.Write($"{i}^2 = ");
        Console.WriteLine(Math.Pow(i, 2));
    }
}