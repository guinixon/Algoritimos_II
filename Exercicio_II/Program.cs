//Implemente um programa , em C#, para ler dois valores numéricos e apresentar a
//diferença do maior pelo menor. Se forem iguais apresentar a mensagem: ‘ Números
//    iguais’.

using System;

internal class Program
{
        private static void Main(string[] args)
        {
            double num1, num2, diferenca;
        Console.WriteLine("Digite o primeiro valor numérico:");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor numérico:");
        num2 = double.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            diferenca = num1 - num2;
            Console.WriteLine($"A diferença do maior pelo menor é: {diferenca}");
        }
        else if (num2 > num1)
        {
            diferenca = num2 - num1;
            Console.WriteLine($"A diferença do maior pelo menor é: {diferenca}");
        }
        else
        {
            Console.WriteLine("Números iguais.");
        }
    }
}