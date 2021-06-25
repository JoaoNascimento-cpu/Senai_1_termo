using System;
using Interface.Classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "PS5";
            p1.Preco = 5000f;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "X Box Series X";
            p2.Preco = 4000f;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "Nintendinho";
            p3.Preco = 3000f;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);

            carrinho.Listar();

            carrinho.Alterar(p1.Codigo, p3);

            carrinho.Listar();


        }
    }
}
