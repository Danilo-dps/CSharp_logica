
Console.WriteLine("Digite o valor: ");
double notas = double.Parse(Console.ReadLine());

int n100 = (int) (notas / 100);
notas %= 100;
int n50 = (int) (notas / 50);
notas %= 50;
int n20 = (int) (notas / 20);
notas %= 20;
int n10 = (int) (notas / 10);
notas %= 10;
int n5 = (int) (notas / 5);
notas %= 5;
int n2 = (int) (notas / 2);
notas %= 2;
int c1 =  (int) (notas / 1);
notas %= 1;
int c05 = (int) (notas / 0.5);
notas %= 0.5;
int c025 = (int) (notas / 0.25);
notas %= 0.25;
int c01 = (int) (notas / 0.1);
notas %= 0.1;
int c005 = (int) (notas / 0.05);
notas %= 0.05;
int c001 = (int) (notas / 0.01);



Console.WriteLine("NOTAS: ");
Console.WriteLine(n100 + " nota(s) de R$ 100.00");
Console.WriteLine(n50 + " nota(s) de R$ 500.00");
Console.WriteLine(n20 + " nota(s) de R$ 20.00");
Console.WriteLine(n10 + " nota(s) de R$ 10.00");
Console.WriteLine(n5 + " nota(s) de R$ 5.00");
Console.WriteLine(n2 + " nota(s) de R$ 2.00");

Console.WriteLine("MOEDAS: ");
Console.WriteLine(c1 + " moeda(s) de R$ 1.00");
Console.WriteLine(c05 + " moeda(s) de R$ 0.50");
Console.WriteLine(c025 + " moeda(s) de R$ 0.25");
Console.WriteLine(c01 + " moeda(s) de R$ 0.10");
Console.WriteLine(c005 + " moeda(s) de R$ 0.05");
Console.WriteLine(c001 + " moeda(s) de R$ 0.01");

