using System;

namespace ClassificacaoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------Notas-----");
            Console.Write("Digite uma nota (0 a 100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota <= 59)
            {
                Console.WriteLine("Nota: E");
            }else if(nota <= 69)
            {
                Console.WriteLine("Nota: D");
            }else if(nota <= 79)
            {
                Console.WriteLine("Nota: C");
            }else if(nota <= 89)
            {
                Console.WriteLine("Nota: B");
            }else if(nota <= 100)
            {
                Console.WriteLine("Nota: A");
            }
            else
            {
                Console.WriteLine("Nota invalida!");
            }

        }
    }
}
