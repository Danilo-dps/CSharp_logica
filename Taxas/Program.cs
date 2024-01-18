double salario = Convert.ToDouble(Console.ReadLine());
double taxa = 0;

if(salario < 2000.01)
{
    Console.WriteLine("Isento");
}
else if(salario > 2000.00 && salario <= 3000.00)
{
    taxa = (salario - 2000.00) * 0.08;
    Console.WriteLine($"R$ {taxa.ToString("F2")}");
}
else if(salario > 3000.00 && salario <= 4500.00)
{
     taxa = ((salario - 3000.00) * 0.18) + (1000 * 0.08);
    Console.WriteLine($"R$ {taxa.ToString("F2")}");
}
else if(salario > 4500.00)
{
    taxa = (1000 * 0.08) + (1500 * 0.18) + ((salario - 4500) * 0.28);
    Console.WriteLine($"R$ {taxa.ToString("F2")}");
}




