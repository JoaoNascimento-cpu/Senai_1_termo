using System;

namespace projeto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

          for (int contador = 300; contador >= 0; contador--)
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resposta * contador}");
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("espero que tenha gostado");
        }
    }
}
