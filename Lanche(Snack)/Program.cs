using System.Runtime.Intrinsics.Arm;
using System.Globalization;

string [] vet = Console.ReadLine().Split(' ');
int x = int.Parse(vet[0]);
int y = int.Parse(vet[1]);

double c1 = 4.00;   
double c2 = 4.50;
double c3 = 5.00;
double c4 = 2.00;
double c5 = 1.50;
double conta = 0;

if(x == 1)
{
    conta = c1 * y;
}
else if(x == 2)
{
    conta = c2 * y;
}
else if(x == 3)
{
    conta = c3 * y;
}
else if(x == 4)
{
    conta = c4 * y;
}
else if(x == 5)
{
    conta = c5 * y;
}

Console.WriteLine($"Total: R$ {conta.ToString("F2", CultureInfo.InvariantCulture)}");