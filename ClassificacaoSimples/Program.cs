string[] valores = Console.ReadLine().Split(' ');
int n1 = Convert.ToInt32(valores[0]);
int n2 = Convert.ToInt32(valores[1]);
int n3 = Convert.ToInt32(valores[2]);

if(n1 < n2 && n2 < n3)
{
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
    Console.WriteLine();
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
}
else if(n1 < n3 && n3 < n2)
{
    Console.WriteLine(n1);
    Console.WriteLine(n3);
    Console.WriteLine(n2);
    Console.WriteLine();
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
}

else if(n2 < n1 && n1 < n3)
{
    Console.WriteLine(n2);
    Console.WriteLine(n1);
    Console.WriteLine(n3);
    Console.WriteLine();
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
}
else if(n2 < n1 && n3 < n1)
{
    Console.WriteLine(n2);
    Console.WriteLine(n3);
    Console.WriteLine(n1);
    Console.WriteLine();
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
}
else if(n3 < n2 && n2 < n1)
{
    Console.WriteLine(n3);
    Console.WriteLine(n2);
    Console.WriteLine(n1);
    Console.WriteLine();
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
}

else
{
    Console.WriteLine(n3);
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine();
    Console.WriteLine(n1);
    Console.WriteLine(n2);
    Console.WriteLine(n3);
}

//beecrowd não aceitou ate aqui
