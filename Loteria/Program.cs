using System;
using System.Globalization;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Digite o valor do premio: ");
                double valorPremio = double.Parse(Console.ReadLine());


                Console.Write("Digite a primeira aposta: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda aposta: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a terceira aposta: ");
                double num3 = double.Parse(Console.ReadLine());

                double somaTotal = num1 + num2 + num3;

                Console.WriteLine();
                Console.WriteLine($"A soma dos valores apostados é {somaTotal}");
                Console.WriteLine();
                Console.WriteLine("A porcentagem que cada apostador vai receber é: ");
                Console.WriteLine($"Apostador um: {num1 / somaTotal:F2}%");   
                Console.WriteLine($"Segundo apostador: {num2 / somaTotal:F2}%");
                Console.WriteLine($"Terceiro apostador: {num3 / somaTotal:F2}%");
                Console.WriteLine();
                Console.Write("A quantidade que cada apostador vai receber é: ");
                Console.WriteLine($"Apostador um: R${num1 / somaTotal * valorPremio:F2}");
                Console.WriteLine($"Segundo apostador: R${num2 / somaTotal * valorPremio:F2}");
                Console.WriteLine($"Terceiro apostador: R${num3 / somaTotal * valorPremio:F2}");

                
            }

        }
    }
}
