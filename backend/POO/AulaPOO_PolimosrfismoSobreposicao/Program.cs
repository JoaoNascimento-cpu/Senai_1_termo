using System;
using Polimorfismo.classes;
namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogador: MegaMen");
            Megamen mega = new Megamen();
            mega.Correr();
            mega.Pular();
            Console.WriteLine("--------------------");
            Console.WriteLine("Jogador: Zero");
            Zero zero = new Zero();
            zero.Correr();
            zero.Pular();
            
        }
    }
}
