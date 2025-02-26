using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obter dois numero do usuario
            // Calcular e apresentar
            // Soma, subtração, multiplicação, divisão, resto da divisão


            Console.Write("Digite o primeiro numero: ");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int numeroDois = int.Parse(Console.ReadLine());

            int soma = numeroUm + numeroDois;
            int subtracao = numeroUm - numeroDois;
            int multiplicacao = numeroUm * numeroDois;
            int divisao = numeroUm / numeroDois;
            int resto = numeroUm % numeroDois;

            Console.WriteLine();
            Console.WriteLine("RESULTADOS");
            Console.WriteLine();

            Console.WriteLine($"Valor Soma: {soma}");
            Console.WriteLine($"Valor Subtração: {subtracao}");
            Console.WriteLine($"Valor Multiplicação: {multiplicacao}");
            Console.WriteLine($"Valor divisão: {(double)divisao}");
            Console.WriteLine($"Valor Resto: {resto}");

            Console.Write("Pressione o ENTER para encerrar. ");
            Console.ReadLine();
        }
    }
}
