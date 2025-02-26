using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            * --Tabuada--
            * 
            * Informe o número da tabuada: 5
            * 5 x 0 = 0
            * 5 x 1 = 5
            * 5 x 2 = 10
            * .
            * .
            * .
            * 5 x 10 = 50
            * 
            * Pressione o ENTER para encerrar.
            */

            Console.WriteLine("--TABUADA--");
            Console.Write("Informe o número da tabuada: ");
            int tabuada = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{tabuada} X 0 = {tabuada * 0}");
            Console.WriteLine($"{tabuada} X 1 = {tabuada * 1}");
            Console.WriteLine($"{tabuada} X 2 = {tabuada * 2}");
            Console.WriteLine($"{tabuada} X 3 = {tabuada * 3}");
            Console.WriteLine($"{tabuada} X 4 = {tabuada * 4}");
            Console.WriteLine($"{tabuada} X 5 = {tabuada * 5}");
            Console.WriteLine($"{tabuada} X 6 = {tabuada * 6}");
            Console.WriteLine($"{tabuada} X 7 = {tabuada * 7}");
            Console.WriteLine($"{tabuada} X 8 = {tabuada * 8}");
            Console.WriteLine($"{tabuada} X 9 = {tabuada * 9}");
            Console.WriteLine($"{tabuada} X 10 = {tabuada * 10}");
            Console.WriteLine();
            Console.WriteLine("Pressione o ENTER para encerrar.");
            Console.ReadKey();


            /*

            int numero, resultado, tabuada;

            Console.Write("Qual tabuada voce quer ? ");
            tabuada = int.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = 0;

            for(numero = 1; numero <= 10; numero++)
            {
                resultado = tabuada * numero;
                Console.WriteLine($"{tabuada} X {numero} = {resultado}");
            }

            Console.ReadKey();

            */
        }
    }
}
