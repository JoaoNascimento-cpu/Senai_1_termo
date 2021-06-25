using System;

namespace funcionarios.classes
{
    public class Funcionarios
    {
        public string[] lista = {"guilherme", "Johnny", "Murilo", "Rafael"};

        public void Mostrar()
        {
            foreach (var item in  lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine("Busca por indice: " + lista[indice]);
        }

        public void Mostrar(string Busca)
        {
            foreach (var item in lista)
            {
                if(item == Busca)
                {
                    Console.WriteLine("Resultado da busca é: " + item);
                }
            }
        }
    }
}