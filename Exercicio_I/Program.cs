// Implemente um programa , em C#, que solicite ao usuário digitar dois números
//nteiros a e b, e de posse destes, imprimir qual o maior valor dos dois e, se for o caso,
//apresente uma mensagem informando que os dois são iguais.

using System;

internal class Program
{
        private static void Main(string[] args)
        {
            int a, b;
        Console.WriteLine("Digite o primeiro número inteiro (a):");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número inteiro (b):");
        b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine($"O maior valor é: {a}");
        }
        else if (b > a)
        {
            Console.WriteLine($"O maior valor é: {b}");
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
    }
}
