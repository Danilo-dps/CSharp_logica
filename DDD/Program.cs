int ddd = Convert.ToInt32(Console.ReadLine());
string escolha;

switch(ddd)
{
    case 11:
    escolha = "Sao Paulo";
    break;

    case 19:
    escolha = "Campinas";
    break;

    case 21:
    escolha = "Rio de Janeiro";
    break;

    case 27:
    escolha = "Vitoria";
    break;

    case 31:
    escolha = "Belo Horizonte";
    break;

    case 32:
    escolha = "Juiz de Fora";
    break;

    case 61:
    escolha = "Brasilia";
    break;

    case 71:
    escolha = "Salvador";
    break;

    default: 
    escolha = "DDD nao cadastrado";
    break;
}

Console.WriteLine(escolha);
