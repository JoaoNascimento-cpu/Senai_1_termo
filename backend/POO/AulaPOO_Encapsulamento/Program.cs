using System;
using Cartão_de_credito.classes;
namespace Cartão_de_credito
{
    class Program
    {
        static void Main(string[] args)
        {
            mastercard m = new mastercard();

            m.NomeTitular = "Sr.Johnny";

            m.Numero = "123456";

            m.Bandeira = "MasterCard";

            Console.WriteLine($"Titular: {m.NomeTitular} \n Token: {m.Token} \n número {m.Numero} \n bandeira {m.Bandeira}");
        }
    }
}
