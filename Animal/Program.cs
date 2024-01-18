string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

if(a == "vertebrado" )
{
    if( b == "ave" && c == "carnivoro")
    {
        Console.WriteLine("aguia");
    }
    else if(b == "mamifero" && c == "onivoro")
    {
        Console.WriteLine("homem");
    }
    else if(b == "mamifero" && c == "herbivoro")
    {
        Console.WriteLine("vaca");
    }
    else
    {
        Console.WriteLine("pomba");
    }

}
else if(a == "invertebrado")
{
    if(b == "inseto" && c == "hematofago")
    {
        Console.WriteLine("pulga");
    }
    else if(b == "inseto" && c == "herbivoro")
    {
        Console.WriteLine("lagarta");
    }
    else if(b == "anelideo" && c == "hematofago")
    {
        Console.WriteLine("sanguessuga");
    }
    else
    {
        Console.WriteLine("minhoca");
    }
}
