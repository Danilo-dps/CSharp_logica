
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int soma = 0;
if(y > x)
{
  for(; y > x; x++)
        {
          if(x % 2 != 0)
          {
            soma = soma + (x);
          }  
        }      
}
else if(x > y)
{
  for(; x > y; y++)                         
        {
          if(y % 2 != 0)
          {
            soma = soma + (y);
          }
        }    
}
Console.WriteLine(soma);

 