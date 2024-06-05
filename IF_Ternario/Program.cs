

int numero = 10;
bool ehPar = false;

Console.WriteLine("IF Ternário: ");
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
