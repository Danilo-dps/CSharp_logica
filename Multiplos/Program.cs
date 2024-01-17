
string [] ab = Console.ReadLine().Split(' ');
int a = Convert.ToInt32(ab[0]);
int b = Convert.ToInt32(ab[1]);

if(a % b == 0 || b % a == 0)
{
    Console.WriteLine("São Multiplos");
}
else
{
    Console.WriteLine("Não são Múltiplos");
}