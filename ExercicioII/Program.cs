using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double ca, co, hip;

            Console.WriteLine("Cateto adjascente:");
            ca = double.Parse(Console.ReadLine());
            Console.WriteLine("Cateto oposto:");
            co = double.Parse(Console.ReadLine());
            hip = Math.Sqrt(Math.Pow(ca, 2) + Math.Pow(co, 2));
        Console.WriteLine($"Hipotenusa = {hip:F2}" );
        }
    }