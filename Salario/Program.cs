using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Faça um Programa que pergunte quanto você ganha por hora 
                 e o número de horas trabalhadas no mês. 
                 Calcule e mostre o total do seu salário no referido mês, 
                 sabendo-se que são descontados 11% para o Imposto de Renda, 
                 8% para o INSS e 5% para o sindicato, 
 
                 Assim, o programa de exibir:
                    salário bruto = gnho por hora * horas trabalhadas no mês
                    quanto pagou ao IR
                    quanto pagou ao INSS
                    quanto pagou ao Sindicato
                    Salário líquido = Salário Bruto - Descontos

                dessa forma:

                + Salário Bruto : R$
                - IR (11%) : R$
                - INSS (8%) : R$
                - Sindicato (5%) : R$
                = Salário Liquido : R$

             */


            const double IR = 0.11;
            const double INSS = 0.08;
            const double SINDICATO = 0.05;

            Console.WriteLine("---Calculo Salário---");
            Console.WriteLine();

            Console.Write("Digite quanto ganha por hora: ");
            double salarioHora = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite quantas horas trabalhou no mês: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double salarioBruto = salarioHora * horasTrabalhadas;

            double valorIR = salarioBruto * IR;
            double valorINSS = salarioBruto * INSS;
            double valorSindicato = salarioBruto * SINDICATO;
            double salarioLiquido = salarioBruto - valorIR - valorINSS - valorSindicato;

            Console.WriteLine($"Salário Bruto do mês R$: {salarioBruto:F2}");
            Console.WriteLine($"Quanto pagou ao (IR) R$: {valorIR:F2}");
            Console.WriteLine($"Quanto pagou ao (INSS) R$: {valorINSS:F2}");
            Console.WriteLine($"Quanto pagou ao (SINDICATO) R$: {valorSindicato:F2}");
            Console.WriteLine($"Salário Liquido: R$ {salarioLiquido:F2}");
            Console.WriteLine();
        }
    }
}
