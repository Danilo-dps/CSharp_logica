using System.Globalization;
string [] notas = Console.ReadLine().Split(' ');
float n1 = Convert.ToSingle(notas[0]);
float n2 = Convert.ToSingle(notas[1]);
float n3 = Convert.ToSingle(notas[2]);
float n4 = Convert.ToSingle(notas[3]);


float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

if(media >= 7)
{
    Console.WriteLine($"Media: {Math.Floor(media * 10) / 10:F1}");
    Console.WriteLine("Aluno aprovado.");
}
else if(media >= 5 && media < 7)
{
    Console.WriteLine($"Media: {media}");
    Console.WriteLine("Aluno em exame.");
    float notaExame = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {Math.Floor(notaExame * 10) / 10:F1}");
    float mediaFinal = (media + notaExame) / 2;
    if(mediaFinal >= 5)
    {
        Console.WriteLine("Aluno aprovado.");
        Console.WriteLine($"Media final: {Math.Floor(mediaFinal * 10) / 10:F1}");
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
        Console.WriteLine($"Media final: {Math.Floor(mediaFinal * 10) / 10:F1}");
    }

}
else
{
    //Console.WriteLine($"Media: {media.ToString("F1")}");
    Console.WriteLine($"Media: {Math.Floor(media * 10) / 10:F1}");
    Console.WriteLine("Aluno reprovado.");
}

//beecrowd 1040




