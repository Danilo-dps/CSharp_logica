
int N = Convert.ToInt32(Console.ReadLine());
 Dictionary<char, int> animals = new Dictionary<char, int> { { 'C', 0 }, { 'R', 0 }, { 'S', 0 } };

for (int i = 0; i < N; i++)
    {
        string[] input = Console.ReadLine().Split(' ');
        int amount = Convert.ToInt32(input[0]);
        char type = Convert.ToChar(input[1]);

        if (animals.ContainsKey(type))
         {
            animals[type] += amount;
         }
    }

int total = animals['C'] + animals['R'] + animals['S'];
Console.WriteLine("Total: " + total + " cobaias");
Console.WriteLine("Total de coelhos: " + animals['C']);
Console.WriteLine("Total de ratos: " + animals['R']);
Console.WriteLine("Total de sapos: " + animals['S']);
Console.WriteLine("Percentual de coelhos: " + ((double)animals['C'] / total * 100).ToString("F2") + " %");
Console.WriteLine("Percentual de ratos: " + ((double)animals['R'] / total * 100).ToString("F2") + " %");
Console.WriteLine("Percentual de sapos: " + ((double)animals['S'] / total * 100).ToString("F2") + " %");