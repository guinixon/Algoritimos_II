using System;

internal class Progam
{
    static void Main(String[] args)
    {
        double r, a, pi = 3.14;
        Console.WriteLine("Raio do circulo: ");
        r = double.Parse(Console.ReadLine());
        a = pi * Math.Pow(r, 2);
        Console.WriteLine($"Area = {a:F2}");
    }
}