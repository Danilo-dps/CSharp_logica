


int n = int.Parse(Console.ReadLine());

int a = 0;

for(int i = 0; i < n; i++)
{
   a = int.Parse(Console.ReadLine());
  if(a == 0)
  {
    Console.WriteLine("NULL");
  }
  else
  {
    if(a > 0 && a % 2 == 0)
    {
        Console.WriteLine("EVEN POSITIVE");
    }
    else if(a < 0 && a % 2 == 0)
    {
        Console.WriteLine("EVEN NEGATIVE");
    }
    else if(a > 0 && a % 2 != 0)
    {
        Console.WriteLine("ODD POSITIVE");
    }
    else
    {
        Console.WriteLine("ODD NEGATIVE");
    }
  }
}

    
    


 //int[] a = new int [n]; COMO DECLARAR UM VETOR