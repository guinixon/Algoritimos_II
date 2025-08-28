using System;

internal class Program
{
    static void Main(string[] args)
    {
        string A, B, C;

        Console.WriteLine("Palavra A:");
        A = Console.ReadLine();
        Console.WriteLine("Palavra B:");
        B = Console.ReadLine();

        Console.WriteLine("A e B são respectivamente:" + A + " e " + B);
        Console.WriteLine();
        C = A;
        A = B;
        B = C;
        Console.WriteLine("A e B foram trocados ");
        Console.WriteLine("Palavra A : " + A);
        Console.WriteLine("Palavra B : " + B);
    }
}