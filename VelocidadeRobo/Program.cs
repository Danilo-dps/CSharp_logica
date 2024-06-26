﻿using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] velocidades = Console.ReadLine().Split(' ');
        int vmin = int.Parse(velocidades[0]);
        int vmax = int.Parse(velocidades[1]);
        string comandos = Console.ReadLine();

        Robo robo = new Robo(vmin, vmax);

        foreach (char c in comandos)
        {
            if (c == 'A')
            {
                robo.Acelerar();
            }
            else if (c == 'D')
            {
                robo.Desacelerar();
            }
        }

        Console.WriteLine(robo.VelocidadeAtual);

    }
}