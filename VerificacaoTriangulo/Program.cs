using System;

namespace VerificacaoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Triângulo-----");

            Console.Write("Triângulo Lado A: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Triângulo Lado B: ");
            int B = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.Write("Triângulo Lado C: ");
            int C = int.Parse(Console.ReadLine());
            
            if(A + B > C && A + C > B && B + C > A)
            {
                Console.WriteLine("É um Triângulo parabéns !");
            }
            else
            {
                Console.WriteLine("Não é um Triângulo");
            }


        }
    }
}
