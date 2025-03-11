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

            
            #region solução 1

            //if (voto > 0 && voto < 5)
            //{
            //    if (voto == 1) Console.WriteLine("Voto : (Cristian)");
            //    if (voto == 2) Console.WriteLine("Voto : (Neymar)");
            //    if (voto == 3) Console.WriteLine("Voto : (Ronaldinho)");
            //    if (voto == 4) Console.WriteLine("Voto : (CR7)");
            //}
            //else if (voto < 7)
            //{
            //    if (voto == 5) Console.WriteLine("Voto : Voto nulo contabilizado...");
            //    if (voto == 6) Console.WriteLine("Voto : Voto branco contabilizado...");
            //}
            //else
            //{
            //    Console.WriteLine("Voto inválido...");
            //}

            //Console.WriteLine("Pressione Enter para finalizar o programa....");
            //Console.ReadLine();

            #endregion

            #region solução 2

            //if (voto > 0 && voto < 5)
            //{
            //    switch (voto)
            //    {
            //        case 1:
            //            Console.WriteLine("Voto : (Cristian)");
            //            break;
            //        case 2:
            //            Console.WriteLine("Voto : (Neymar)");
            //            break; 
            //        case 3:
            //            Console.WriteLine("Voto : (Ronaldinho)");
            //            break;
            //        case 4:
            //            Console.WriteLine("Voto : (CR7)");
            //            break;
            //    }
            //}
            //else if (voto < 7)
            //{
            //    switch (voto)
            //    {
            //        case 5:
            //            Console.WriteLine("Voto : (Nulo)");
            //            break;
            //        case 6:
            //            Console.WriteLine("Voto : (Branco)");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Voto inválido...");
            //}

            #endregion

            #region 3 Eleição com Loop

            //const int CANDIDATO1 = 1, CANDIDATO2 = 2, CANDIDATO3 = 3, CANDIDATO4 = 4;
            //const int NULO = 5, BRANCO = 6;
            //int contabilizadoComSucesso = 0, contabilizadoNulo = 0, contabilizadoBranco = 0,
            //    contabilizadoInvalido = 0;
            //int opcao = 1;


            //Console.WriteLine("--Votação--\n");

            //do
            //{
            //    Console.Clear();

            //    Console.WriteLine("ESCOLHA SUA OPÇÃO\n");

            //    Console.WriteLine("1 - Candidato 1");
            //    Console.WriteLine("2 - Candidato 2");
            //    Console.WriteLine("3 - Candidato 3");
            //    Console.WriteLine("4 - Candidato 4");
            //    Console.WriteLine("5 - Nulo");
            //    Console.WriteLine("6 - Branco\n");

            //    Console.Write("Digite seu voto : ");
            //    uint voto = uint.Parse(Console.ReadLine());

            //    switch (voto)
            //    {
            //        case CANDIDATO1:
            //        case CANDIDATO2:
            //        case CANDIDATO3:
            //        case CANDIDATO4:
            //            Console.WriteLine("Voto contabilizado com sucesso...");
            //            contabilizadoComSucesso++;
            //            break;
            //        case NULO:
            //            Console.WriteLine("Voto nulo contabilizado...");
            //            contabilizadoNulo++;
            //            break;
            //        case BRANCO:
            //            Console.WriteLine("Voto branco contabilizado...");
            //            contabilizadoBranco++;
            //            break;
            //        default:
            //            Console.WriteLine("Voto Inválido...");
            //            contabilizadoInvalido++;
            //            break;
            //    }

            //    Console.WriteLine("1 - sim\n2- não");
            //    Console.Write("Deseja votar novamente? digite o número referente a opção: ");
            //    opcao = int.Parse(Console.ReadLine());
            //    Console.WriteLine();


            //}
            //while (opcao == 1);

            //int contabilizadoTotal = contabilizadoComSucesso + contabilizadoNulo + contabilizadoBranco + contabilizadoInvalido;

            //Console.WriteLine($"----Contabilizado com sucesso: {contabilizadoComSucesso}");
            //Console.WriteLine($"----Nulo: {contabilizadoNulo} ");
            //Console.WriteLine($"----Branco: {contabilizadoBranco}");
            //Console.WriteLine($"----Inválidos: {contabilizadoInvalido}");
            //Console.WriteLine($"----Total de votos: {contabilizadoTotal}");

            //Console.WriteLine("Pressione Enter para finalizar o programa....");
            //Console.ReadLine();

            #endregion

        }
    }
}
