string[] medidas = Console.ReadLine().Split(' ');
float a = Convert.ToSingle(medidas[0]);
float b = Convert.ToSingle(medidas[1]);
float c = Convert.ToSingle(medidas[2]);
float trapezio = (a + b) * c / 2;

if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine($"Perimetro = {(a + b + c).ToString("F1")}"); 

}
else
{
    Console.WriteLine($"Area = {Math.Floor(trapezio * 10) / 10:F1}");
}
