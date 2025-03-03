using System;

namespace Votacao
{
    internal class Program
    {

        /* Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.Os códigos utilizados são:
        • 1,2,3,4 votos para os respectivos candidatos;
        • 5 voto nulo; 
        • 6 voto em branco.
        Assim, escreva um programa para receber um único voto e imprima: 
        • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
        • Se o usuário votou nulo: "Voto nulo contabilizado..."
        • Se o usuário votou em branco: "Voto branco contabilizado...
        Se o voto for diferente de todas as opções acima: "Voto inválido..."
        */
        static void Main(string[] args)
        {

            Console.WriteLine("----Eleição presidencial----");
            Console.WriteLine();

            Console.WriteLine("Escolha seu voto!---- \n1: Cristian \n2: Neymar \n3: Ronaldinho \n4: CR7 \n5: Nulo \n6: Branco");
            Console.WriteLine();
            int voto = int.Parse(Console.ReadLine());

            if (voto > 0 && voto < 5)
            {
                if (voto == 1) Console.WriteLine("Voto : (Cristian)");
                if (voto == 2) Console.WriteLine("Voto : (Neymar)");
                if (voto == 3) Console.WriteLine("Voto : (Ronaldinho)");
                if (voto == 4) Console.WriteLine("Voto : (CR7)");
            }
            else if (voto < 7)
            {
                if (voto == 5) Console.WriteLine("Voto : Voto nulo contabilizado...");
                if (voto == 6) Console.WriteLine("Voto : Voto branco contabilizado...");
            }
            else
            {
                Console.WriteLine("Voto inválido...");
            }

            Console.WriteLine("Pressione Enter para finalizar o programa....");
            Console.ReadLine();

        }
    }
}
