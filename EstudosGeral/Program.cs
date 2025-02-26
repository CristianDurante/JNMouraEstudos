using System;

namespace EstudosGeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------CNH-----");

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18) Console.WriteLine("Você tem idade para dirigir! ");
            else Console.WriteLine("Você não tem idade para dirigir! ");

            

        }
    }
}
