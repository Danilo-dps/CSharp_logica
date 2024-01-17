string[] coordenadas = Console.ReadLine().Split(' ');
float x = Convert.ToSingle(coordenadas[0]);
float y = Convert.ToSingle(coordenadas[1]);

if(x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
else if(x > 0 || x < 0 && y == 0)
{
    Console.WriteLine("Eixo X");
}
else if(x == 0 && y > 0 || y < 0)
{
    Console.WriteLine("Eixo Y");
}
else
{
    Console.WriteLine("Origem");
}