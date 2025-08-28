using System;
internal class Program
{
    static void Main(string[] args)
    {
        double salarioMin, salario, quantidade;

        Console.WriteLine("Digite o valor do salário mínimo atual: ");
        salarioMin = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o seu salário: ");
        salario = double.Parse(Console.ReadLine());
        quantidade = salario / salarioMin;
        Console.WriteLine($"Salarios minimos: {quantidade:F2}");
    }
}