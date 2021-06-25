using System;
using System.Collections.Generic;
using Shop.Classes;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> produto = new List<Produtos>();

            Produtos[] arreyProdutos = {};

            produto.Add(new Produtos(1, "Air Fryer Phyllips Wallita", 1000.00f));
            produto.Add(new Produtos(2, "Motorola One +", 800.00f));
            produto.Add(new Produtos(3, "Playstation 5", 4000.00f));
            produto.Add(new Produtos(4, "Geladeira", 5500.00f));
            produto.Add(new Produtos(5, "Teclado RGB", 550.00f));
            produto.Add(new Produtos(6, "Notebook Asus", 3090.00f));
            produto.Add(new Produtos(7, "X Caixa Seríre X", 2000.00f));

            Produtos p1 = new Produtos();
            p1.Nome = "Air Fryer Phyllips Wallita";
            p1.Preco = 1000.00f;

            produto.Add(p1);

            foreach (Produtos elemento in produto)
            {
                Console.WriteLine(elemento.Nome);
            }

            produto.RemoveAt(3);
            Console.WriteLine("---------------------");
            Console.WriteLine("Remoção feita");
            Console.WriteLine("---------------------");

            foreach (Produtos elemento in produto)
            {
                Console.WriteLine(elemento.Nome);
            }
            
            Console.WriteLine("---------------------");
            Console.WriteLine("Remoção feita");
            Console.WriteLine("---------------------");

            produto.RemoveAll(x => x.Codigo == 5);
            foreach (Produtos elemento in produto)
            {
                Console.WriteLine(elemento.Nome);
            }

        }
    }
}
