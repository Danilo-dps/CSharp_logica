

int x, y, z;

string[] vet = Console.ReadLine().Split(' ');

x = int.Parse(vet[0]);
y = int.Parse(vet[1]);
z = int.Parse(vet[2]);

int menor = x;
if(y < x && y < z)
{
    menor = y;
}
else if(x > z)
{
    menor = z;
}

Console.WriteLine("MENOR = " + menor);

