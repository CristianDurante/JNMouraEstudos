using System;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {

             /*
             * Usuário vai entrar com dois números inteiros
             * Compará-los *  
             *  Exibir o Maior
             *  Exibir o Menor
             *  São iguais
             */

            Console.WriteLine("-------Maior ou Menos------");

            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 > num1) 
            {
                Console.WriteLine("O maior numero é o Numero 2!");
                Console.WriteLine("O menor numero é o Numero 1!");
            }
            else if(num1 > num2)
            {
                Console.WriteLine("O maior numero é o Numero 1!");
                Console.WriteLine("O menor numero é o Numero 2!");
            }else
            {
                Console.WriteLine("Os números são iguais! ");
            }

        }
    }
}
