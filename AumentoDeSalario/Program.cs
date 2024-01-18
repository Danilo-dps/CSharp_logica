

double salario = Convert.ToDouble(Console.ReadLine());
double nSalario = 0;

if(salario <= 400.0)
{
    nSalario = salario * 1.15;
}
else if(salario > 400.00 && salario <= 800.00)
{
    nSalario = salario * 1.12;
}
else if(salario > 800.00 && salario <= 1200.00)
{
    nSalario = salario * 1.1;
}
else if(salario > 1200.00 && salario <= 2000.00)
{
    nSalario = salario * 1.07;
}
else
{
    nSalario = salario * 1.04;
}
double reajuste = nSalario - salario;
double percentual = (reajuste / salario) * 100.00;

Console.WriteLine($"Novo salario: {nSalario.ToString("F2")}");
Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
Console.WriteLine($"Em percentual: {percentual.ToString("F0")} %");