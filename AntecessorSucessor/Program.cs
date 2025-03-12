using System;

namespace AntecessorSucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Solução 1 Simples

            //int n1, n2, n3, resultado;

            //Console.WriteLine("Digite o n1:");
            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o n2:");
            //n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o n3:");
            //n3 = int.Parse(Console.ReadLine());

            //resultado = (n1 + n2 + n3) / 3;

            //Console.WriteLine($"A Média é: {resultado}");

            #endregion

            #region Solução 2 Usando do while

            //int opcao;

            //do
            //{
            //    Console.Write("Digite o 1° Numero:");
            //    n1 = int.Parse(Console.ReadLine());

            //    Console.Write("Digite o 2° Numero:");
            //    n2 = int.Parse(Console.ReadLine());

            //    Console.Write("Digite o 3° Numero:");
            //    n3 = int.Parse(Console.ReadLine());

            //    resultado = (n1 + n2 + n3) / 3;

            //    Console.WriteLine($"A Média é: {resultado}");

            //    Console.WriteLine("Deseja fazer outra soma ? 1-Sim 2-Não");
            //    opcao = int.Parse(Console.ReadLine());

            //}
            //while (opcao == 1 || opcao < 0);

            //Console.WriteLine("Aperte Enter para encerrar o programa!");
            //Console.ReadLine();

            #endregion

            #region AntecessorSucessor Solução 1 Simples

            //Console.Write("Digite um numero: ");
            //int numero = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine($"Numero Sucessor: {numero + 1}");
            //Console.WriteLine($"Numero Antecessor: {numero - 1}");

            #endregion

            #region AntecessorSucessor Solução 2 If Else

            //Console.Write("Digite um numero: ");
            //int numero = int.Parse(Console.ReadLine());

            //if(numero > 0 && numero < 100)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Numero Sucessor: {numero + 1}");
            //    Console.WriteLine($"Numero Antecessor: {numero - 1}");
            //}
            //else
            //{
            //    Console.WriteLine("Numero invalido!");
            //}

            //Console.WriteLine("Aperte Enter para encerrar o programa");
            //Console.ReadLine();

            #endregion

            #region AntecessorSucessor Solução 3 do While

            //bool opcao;
            //int numero = 0;

            //do
            //{
            //    Console.Write("Digite um numero:");
            //    opcao = int.TryParse(Console.ReadLine(), out numero);
            //}
            //while (!opcao || numero < 0);

            #endregion

        }
    }
}
