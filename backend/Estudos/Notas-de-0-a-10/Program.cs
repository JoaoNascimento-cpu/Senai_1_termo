using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota;
            
            do{
                Console.WriteLine("Digite uma nota de 0 a 10");
                Nota = double.Parse(Console.ReadLine( ) );

                if(!(Nota >= 0 && Nota <= 10)) {
                    Console.WriteLine("Nota inválida");
                }
            }while( Nota >= 0 && Nota <= 10);

            Console.WriteLine("número aceito");
        }
    }
}
