using System;

namespace informações_usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;
            char estadoCivil;

            do
            {
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();
            }while(nome == "" || nome == " " );

            do
            {
                Console.WriteLine("Digite sua idade:");
                idade = int.Parse(Console.ReadLine() );

            }while(idade <= 0 || idade >= 150);

            do
            {
                Console.WriteLine("Digite seu salário:");
                salario = double.Parse(Console.ReadLine() );

            }while(!(salario > 0) );

            do
            {
                Console.WriteLine("Digite seu estado civil:");
                string estado = Console.ReadLine();
                estadoCivil = estado.ToCharArray()[0];

            }while(estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v');

            Console.WriteLine("Dados aceitos :)");

            
        }
    }
}