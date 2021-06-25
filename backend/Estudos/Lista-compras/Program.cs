using System;

namespace Arrey
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listacompras = {"maçã", "potatoes", "french fries"};
            double[] precos = {1.1, 2.5, 5.7};
            int[] idades = {16, 17, 18};

            string[] nomealunos = new string[5];

            //Console.WriteLine(listacompras[2]);

            //Console.WriteLine("Trocar potatoes por qual item?");

            //listacompras[1] = Console.ReadLine();

            //Console.WriteLine(listacompras[1]);

            for(int i = 0; i <listacompras.Length; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(listacompras[i]);
            }

        }
    }
}
