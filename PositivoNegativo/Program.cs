using System;

namespace PositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Positivo Ou Negativo-----");

            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            if(num >= 0)
            {
                Console.WriteLine("Numero Positivo!");
            }
            else
            {
                Console.WriteLine("Numero Negativo!");
            }

        }
    }
}
