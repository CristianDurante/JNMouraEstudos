using System;

namespace EstudosGeral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problema "retangulo" 

            //Console.WriteLine("---Retangulo---");
            //Console.WriteLine();

            //Console.Write("Base do retangulo: ");
            //double baseRetangulo = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Altura do retangulo: ");
            //double alturaRetangulo = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //double area = baseRetangulo * alturaRetangulo;
            //double perimentro = (baseRetangulo + alturaRetangulo) * 2;
            //double diagonal = Math.Sqrt(baseRetangulo * baseRetangulo + alturaRetangulo * alturaRetangulo);

            //Console.WriteLine($"AREA = {area:F4}");
            //Console.WriteLine($"PERIMETRO = {perimentro:F4}");
            //Console.WriteLine($"DIAGONAL = {diagonal:F4}");

            #endregion

            #region Problema "troco" 

            //Console.WriteLine("---Troco---");
            //Console.WriteLine();

            //Console.Write("Preço unitário do produto: ");
            //double precoUnitario = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade comprada: ");
            //int quantidade = int.Parse(Console.ReadLine());
            //Console.Write("Dinheiro recebido: ");
            //double dinheiroRecebido = double.Parse(Console.ReadLine());

            //double total = dinheiroRecebido - quantidade * precoUnitario;

            //Console.WriteLine($"TROCO = {total:F2}");

            #endregion

            #region Problema "circulo"  

            //Console.WriteLine("---Circulo---");
            //Console.WriteLine();

            //Console.Write("Digite o valor do raio do circulo: ");
            //double raio = double.Parse(Console.ReadLine());

            //double area = 3.14159 * raio * raio;

            //Console.WriteLine($"AREA = {area:F3}");

            #endregion

            #region Problema "pagamento"  

            //Console.WriteLine("---Pagamento---");
            //Console.WriteLine();

            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Valor por hora: ");
            //double valorHora = double.Parse(Console.ReadLine());
            //Console.Write("Horas trabalhadas: ");
            //double horasTrabalhada = double.Parse(Console.ReadLine());

            //double soma = horasTrabalhada * valorHora;

            //Console.WriteLine();
            //Console.WriteLine($"O pagamento para {nome} deve ser {soma:F2}");

            #endregion

            #region Problema "medidas"

            //Console.WriteLine("---medidas---");
            //Console.WriteLine();


            //Console.Write("Digite a medida A: ");
            //double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Digite a medida B: ");
            //double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Digite a medida C: ");
            //double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaQuadrado = A * A;
            //double areaTriangulo = (A * B) / 2;
            //double areaTrapezio = (A + B) * C / 2;

            //Console.WriteLine($"AREA DO QUADRADO = {areaQuadrado:F4}");
            //Console.WriteLine($"AREA DO TRIANGULO = {areaTriangulo:F4}");
            //Console.WriteLine($"AREA DO TRAPEZIO = {areaTrapezio:F4}");


            #endregion

            #region Estrutura repetição FOR

            //for (int i = 0; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Estrutura repetição de 0 a 100 somendo com numeros pares

            //int i = 101;

            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}

            #endregion

            #region Estrutura repetição "Senha"

            //Console.Write("Digite uma senha: ");
            //string senha = Console.ReadLine();

            //while (senha != "1234")
            //{
            //    Console.WriteLine("Senha invalida! Digite novamente..");
            //    senha = Console.ReadLine();
            //}

            #endregion

            #region Estrutura repetição do while "tabuada"

            //Console.Write("Digite a tabuada: ");
            //int tabuada = int.Parse(Console.ReadLine());

            //int i = 0;

            //do
            //{
            //    Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
            //    i++;
            //}while (i <= 10);

            #endregion

            #region TESTE MESA

            //int i = 0, j = 0, x = 1;
            //for (; i < 2;)
            //{
            //    for (j = 2; j > -1; j--)
            //    {
            //        x += i + j;
            //    }
            //    i++;
            //    do
            //    {
            //        x += j;
            //        j++;
            //    } while (j < 2);
            //}
            //while (x < 20)
            //{
            //    x += 2;
            //    if (x % 2 == 0)
            //    {
            //        x--;
            //    }
            //}

            //Console.WriteLine(x);
            //Console.WriteLine(j);
            //Console.WriteLine(i);

            #endregion

            #region Elevador

            // Faça um programa que mostre se um elevador pode entrar em funcionamento ou não.
            //Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador e o
            //número de pessoas que desejam utilizá-lo. Depois, solicitar o peso de cada pessoa e, no
            //final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma dos pesos
            //das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar
            //em funcionamento.


            //Console.WriteLine("\n----------Elevador----------\n");

            //Console.WriteLine("Informe o peso maximo em kg do elevador: ");
            //double pesoElevador = double.Parse(Console.ReadLine());

            //Console.Write("Informe a quantidade de pessoas que iram utilizar o elevador: ");
            //int qtdPessoa = int.Parse(Console.ReadLine());
            //double pesoTotal = 0;

            //for (int i = 0; i < qtdPessoa; i++)
            //{
            //    Console.Write("Informe seu peso: ");
            //    double pesoPessoa = double.Parse(Console.ReadLine());
            //    pesoTotal += pesoPessoa;
            //}
            //Console.WriteLine(pesoTotal);

            //if (pesoTotal < pesoElevador)
            //    Console.WriteLine("Entrou em funcionamento");
            //else
            //    Console.WriteLine("Limite atingido!");

            //Console.WriteLine("\nPressine ENTER para encerrar.");
            //Console.ReadLine();

            #endregion

            #region "do while" TryParse

            //int numeroDePessoas = 0;
            //bool deuCerto;

            //do
            //{
            //    Console.Write("Número de pessoas que desejam utilizá-lo:");
            //    deuCerto = int.TryParse(Console.ReadLine(), out numeroDePessoas);
            //} while (deuCerto == false || numeroDePessoas < 0);

            #endregion

            #region arrays e matriz

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numeros[3] + numeros[2]);



            #endregion


        }
    }
}
