using System;

namespace Tabuada_inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada
            Console.WriteLine("Qual tabuada você quer ver?");
            int resposta = int.Parse(Console.ReadLine( ) );
            
            int resultado;

            //processamento

            for(int contador = 20; contador >=0; contador--)
            {
                resultado = resposta * contador;
                Console.WriteLine($" {resposta} * {contador} = {resultado} ");
                System.Threading.Thread.Sleep(200);
            }
            
            
        }
    }
}
