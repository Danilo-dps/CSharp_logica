int n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < n; i++)
{
   string[] valores = Console.ReadLine().Split(' ');
   double a = Convert.ToDouble(valores[0]) * 2;
   double b = Convert.ToDouble(valores[1]) * 3;
   double c = Convert.ToDouble(valores[2]) * 5;
   double media = (a + b + c) / 10;

   Console.WriteLine($"{media.ToString("F1")}");
}