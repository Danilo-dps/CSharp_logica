
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int soma = 0;

if (x < y)
{
    // Inverte os valores de x e y
    int temp = x;
    x = y;
    y = temp;
}
y += 1;
for (; y < x; y++)
{
    if (y % 2 == 1)
    {
        soma += y;
    }
    if(y % 2 < 0 && y % 2 == -1){
      soma += y;
    }
}

Console.WriteLine(soma);


 