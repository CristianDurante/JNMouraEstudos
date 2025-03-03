using System;
using System.Diagnostics;

namespace Posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Analise a seguinte informação:

                Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:

                Álcool
                até 20 litros (inclusive 20 litros), desconto de 2% por litro
                acima de 20 litros, desconto de 5% por litro

                Gasolina
                até 20 litros (inclusive 20 litros), desconto de 3% por litro
                acima de 20 litros, desconto de 6% por litro

                Após à análise, faça um programa que leia o número de litros vendidos 
                e o tipo de combustível (codificado da seguinte forma: 1-álcool, 2-gasolina).
                calcule e imprima o valor a ser pago pelo jogador, sabendo-se que 
                o preço do litro da gasolina é R$ 6.10 e o preço do litro do álcool é R$ 4.20
             */

            const double PRECOGASOLINA = 6.10;
            const double PRECOALCOOL = 4.20;

            Console.WriteLine("---Combustivel---");
            Console.WriteLine();

            Console.WriteLine("Digite qual tipo de combustível: \n1-álcool (R$: 4.20L) \n2-gasolina (R$: 6.10L)");
            int tipoCombustivel = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a quantidade de litros de combustível: ");
            double litrosCombustivel = double.Parse(Console.ReadLine());

            
            double precoTotalAlcool = litrosCombustivel * PRECOALCOOL;
            double precoTotalGasolina = litrosCombustivel * PRECOGASOLINA;

            switch (tipoCombustivel)
            {
                case 1:
                    if(litrosCombustivel > 0 && litrosCombustivel <= 20)
                    {
                        double descontoAlcool = precoTotalAlcool * 0.02;
                        Console.WriteLine($"Tipo do combustível: Álcool ");
                        Console.WriteLine($"Preço Total: {precoTotalAlcool:F2}");
                        Console.WriteLine($"Preço com desconto de 2%: {precoTotalAlcool - descontoAlcool:F2}");
                    }
                    else
                    {
                        double descontoAlcool = precoTotalAlcool * 0.05;
                        Console.WriteLine($"Tipo do combustível: Álcool ");
                        Console.WriteLine($"Preço Total: {precoTotalAlcool:F2}");
                        Console.WriteLine($"Preço com desconto de 5%: {precoTotalAlcool - descontoAlcool:F2}");
                    }
                break;
                case 2:
                    if (litrosCombustivel > 0 && litrosCombustivel <= 20)
                    {
                        double descontoGasolina = precoTotalGasolina * 0.03;
                        Console.WriteLine($"Tipo do combustível: Gasolina ");
                        Console.WriteLine($"Preço Total: {precoTotalGasolina:F2}");
                        Console.WriteLine($"Preço com desconto de 3%: {precoTotalGasolina - descontoGasolina:F2}");
                    }
                    else
                    {
                        double descontoGasolina = precoTotalGasolina * 0.06;
                        Console.WriteLine($"Tipo do combustível: Gasolina ");
                        Console.WriteLine($"Preço Total: {precoTotalGasolina:F2}");
                        Console.WriteLine($"Preço com desconto de 6%: {precoTotalGasolina - descontoGasolina:F2}");
                    }
                break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Escolha invalida!");
                    break;
            }

            Console.WriteLine("Pressione a tecla Enter para encerrar o programa...");
            Console.ReadLine();

        }
    }
}
