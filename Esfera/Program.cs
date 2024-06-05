
using System;
using System.Globalization;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;
    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    volume = (pi * 4 * Math.Pow( raio , 3 ))/ 3;
    
    Console.WriteLine($"VOLUME =  {volume:F3}", CultureInfo.InvariantCulture);
  }

}