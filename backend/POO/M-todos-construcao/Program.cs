using System;
using Name.Classes;
namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string primeiroNome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome agora:");
            string sobreNome = Console.ReadLine();
            Pessoa pessoa = new Pessoa(primeiroNome, sobreNome);
        }
    }
}
