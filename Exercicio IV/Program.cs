using System;
internal class Program
{
    static void Main(string[] args)
    {

        double kg, peso, valor;

        Console.WriteLine("Valor do KG:");
        kg = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o peso em KG da refeicao:");
        peso = double.Parse(Console.ReadLine());
        valor = peso * kg;
        Console.WriteLine($"O valor a pagar: {valor:F2}" );
    }
}