string [] tempo = Console.ReadLine().Split(' ');
int inicio = Convert.ToInt32(tempo[0]);
int fim = Convert.ToInt32(tempo[1]);
int duracao = 0;
if(inicio < fim)
{
   duracao = fim - inicio;
}
else
{
   duracao = (24 - inicio) + fim;
}

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
