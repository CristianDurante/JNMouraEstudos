using System;

namespace AntecessorSucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3, resultado;

            Console.WriteLine("Digite o n1:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o n2:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o n3:");
            n3 = int.Parse(Console.ReadLine());

            resultado = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A Média é: {resultado}");
        }
    }
}
