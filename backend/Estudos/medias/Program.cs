using System;

namespace Projeto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            string situacao = "";

            Console.WriteLine("media: " , + media);

            if(media > 7) {
                situacao = "Aprovado :)";
            } else{
                situacao = "Reprovado, melhor estudar novamente. :(";
            }

            Console.WriteLine(situacao);
        }
    }
}