using System;

namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Faça um programa para ler três notas e o número de faltas de um aluno
                e escrever qual a sua situação final: Aprovado, Reprovado por Falta ou Reprovado 
                por Média. A média para aprovação é 7,0 e o limite de faltas é 25% do total de aulas. 
                O número de aulas ministradas no semestre foi de 80. A reprovação por falta sobrepõe 
                a reprovação por Média.
            */

            Console.WriteLine("---NOTAS---");

            const double MEDIA = 7;
            const int LIMITEFALTAS = 20;

            Console.Write("Digite o numero de faltas: ");
            int faltas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (faltas > 0 && faltas <= LIMITEFALTAS)
            {
                Console.Write("Digite a primeira nota: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("Digite a terceira nota: ");
                double nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine();

                double notaFinal = (nota1 + nota2 + nota3) / 3;

                if(notaFinal > 0 && notaFinal >= MEDIA)
                {
                    Console.WriteLine($"A media das 3 notas é: {notaFinal:F2} ");
                    Console.WriteLine("Parabéns voce foi APROVADO!");
                }else
                {
                    Console.WriteLine($"Sua Média foi: {notaFinal:F2} (REPROVADO)");
                }
            }else
            {
                Console.WriteLine("Você foi reprovado por falta!");
            }

            Console.WriteLine("Aperte Enter para finalizar o programa..");
            Console.ReadLine();

        }
    }
}
