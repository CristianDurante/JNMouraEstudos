using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--Senha--");
            Console.WriteLine();

            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();

            
            if(senha == "123")
            {
                Console.WriteLine("Senha Correta");
            }

           // Console.WriteLine((senha == "123") ? "Senha Correta" : "Senha incorreta");

        }
    }
}
