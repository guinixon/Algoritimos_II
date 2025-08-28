//Implemente um programa , em C#, que leia o nome de um dia da semana e escreva
//    uma mensagem “FIM DE SEMANA” caso seja sábado ou domingo.


using System;
internal class Program
{
        private static void Main(string[] args)
        {
            string dia;
        Console.WriteLine("Digite o nome de um dia da semana:");
        dia = Console.ReadLine().ToLower();
        while (dia != "segunda" && dia != "terça" && dia != "terca" && dia != "quarta" && dia != "quinta" && dia != "sexta" &&
               dia != "sábado" && dia != "sabado" && dia != "domingo")
        {
            Console.WriteLine("Digite um dia da semana válido");
            dia = Console.ReadLine().ToLower();
        }
        if (dia == "sábado" || dia == "sabado" || dia == "domingo")
        {
            Console.WriteLine("FIM DE SEMANA");
        }
    }
}