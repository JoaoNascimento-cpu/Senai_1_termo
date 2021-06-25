using System;

namespace Projeto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número ae meu rei:");
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.WriteLine("Digite o segundo número ae meu rei: ");
            int num2 = int.Parse(Console.ReadLine());
            
            int multiplicação = num1 * num2 ;
            
            Console.Write("Here is the result: ");
            Console.WriteLine(multiplicação);
        }
    }
}
