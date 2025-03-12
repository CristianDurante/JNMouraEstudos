using System;
using System.Diagnostics;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obter dois numero do usuario
            // Calcular e apresentar
            // Soma, subtração, multiplicação, divisão, resto da divisão

            #region Solução 3 "do While && Switch case"

            //Console.Write("Digite o primeiro numero:");
            //int numero1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo numero:");
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //bool opcaoLoop;
            //int numero;

            //do
            //{

            //    Console.WriteLine("Deseja fazer qual Operação ? '+' '-' '*' '/': ");
            //    string opcao = Console.ReadLine();

            //    Console.WriteLine();
            //    switch (opcao)
            //    {
            //        case "+":
            //            int soma = numero1 + numero2;
            //            Console.WriteLine($"Valor Soma: {soma}");
            //            break;
            //        case "-":
            //            int subtracao = numero1 - numero2;
            //            Console.WriteLine($"Valor Subtração: {subtracao}");
            //            break;
            //        case "*":
            //            int multiplicacao = numero1 * numero2;
            //            Console.WriteLine($"Valor Multiplicação: {multiplicacao}");
            //            break;
            //        case "/":
            //            int divisao = numero1 / numero2;
            //            Console.WriteLine($"Valor divisão: {(double)divisao:F2}");
            //            break;
            //        default:
            //            Console.WriteLine("Opão invalida!");
            //            break;
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Deseja fazer outra operação ?: 1-SIM 2-NÃO");
            //    opcaoLoop = int.TryParse(Console.ReadLine(), out numero);

            //}while (!opcaoLoop || numero == 1 ); 
            
            #endregion

            #region Solução 2 Switch case

            //Console.Write("Digite o primeiro numero:");
            //int numero1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo numero:");
            //int numero2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Deseja fazer qual Operação ? '+' '-' '*' '/': ");
            //string opcao = Console.ReadLine();

            //Console.WriteLine();
            //switch (opcao)
            //{
            //    case "+": 
            //        int soma = numero1 + numero2;
            //        Console.WriteLine($"Valor Soma: {soma}");
            //        break;
            //    case "-":
            //        int subtracao = numero1 - numero2;
            //        Console.WriteLine($"Valor Subtração: {subtracao}");
            //        break;
            //    case "*": 
            //        int multiplicacao = numero1 * numero2;
            //        Console.WriteLine($"Valor Multiplicação: {multiplicacao}");
            //        break;
            //    case "/":
            //        int divisao = numero1 / numero2;
            //        Console.WriteLine($"Valor divisão: {(double)divisao}");
            //        break;
            //    default: Console.WriteLine("Opão invalida!");
            //        break;
            //}

            #endregion

            #region Solução 1 Simples

            //Console.Write("Digite o primeiro numero: ");
            //int numeroUm = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo numero: ");
            //int numeroDois = int.Parse(Console.ReadLine());

            //int soma = numeroUm + numeroDois;
            //int subtracao = numeroUm - numeroDois;
            //int multiplicacao = numeroUm * numeroDois;
            //int divisao = numeroUm / numeroDois;
            //int resto = numeroUm % numeroDois;

            //Console.WriteLine();
            //Console.WriteLine("RESULTADOS");
            //Console.WriteLine();

            //Console.WriteLine($"Valor Soma: {soma}");
            //Console.WriteLine($"Valor Subtração: {subtracao}");
            //Console.WriteLine($"Valor Multiplicação: {multiplicacao}");
            //Console.WriteLine($"Valor divisão: {(double)divisao}");
            //Console.WriteLine($"Valor Resto: {resto}");

            //Console.Write("Pressione o ENTER para encerrar. ");
            //Console.ReadLine();

            #endregion
        }
    }
}
