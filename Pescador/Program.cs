using System;

namespace Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*Pescador comprou um microcomputador para controlar o rendimento
            //* diário de seu trabalho.Toda vez que ele traz um peso de peixes maior que o e
            //* stabelecido pelo regulamento de pesca do estado de São Paulo(50 quilos) deve
            //* pagar uma multa de R$ 4,00 por quilo excedente.Assim, faça um
            //    programa que leia o peso de peixes e verifique se há excesso. Se houver, o programa
            //    também deve calcular o valor da multa que o pescador deverá pagar.
            //    No final, o programa deve imprimir o excesso e a multa paga pelo pescador


            #region Pescador <<<<---

            Console.Write("Digite o peso do peixe: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double multa = 4;
            double limitePeso = 50;

            if (peso > limitePeso)
            {
                double pesoExcedido = peso - limitePeso;
                double multaExcedida = multa * pesoExcedido;
                Console.WriteLine($"Peso excedido: {pesoExcedido}Kg");
                Console.WriteLine($"Valor da multa: R${multaExcedida:F2}");
            }
            else
            {
                Console.WriteLine("Não teve multa!");
            }

            Console.WriteLine("Aperte enter para finalizar o programa.");
            Console.ReadLine();

            #endregion

            #region Terreno <<<<---

            //Console.Write("Digite a largura do terreno: ");
            //double largura = double.Parse(Console.ReadLine());

            //Console.Write("Digite o comprimento do terreno: ");
            //double comprimento = double.Parse(Console.ReadLine());

            //Console.Write("Digite o valor do metro quadrado: ");
            //double metroQuadrado = double.Parse(Console.ReadLine());

            //double areaTerreno = largura * comprimento;
            //double precoTerreno = areaTerreno * metroQuadrado;

            //Console.WriteLine($"Area do terreno = {areaTerreno:F2}");
            //Console.WriteLine($"Preco do terreno = {precoTerreno:F2}");

            #endregion



        }
    }
}
