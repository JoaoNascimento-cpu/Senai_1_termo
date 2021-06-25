using System;
using objetoArgumento.Classes;

namespace objetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Spyro", 50.00f);
            Produto p2 = new Produto(2, "Rainbow Seis", 100.00f);
            Produto p3 = new Produto(3, "Yes Womans Land", 37.68f);
            Produto p4 = new Produto(4, "GTA VIce City", 200.00f);
            Produto p5 = new Produto(5, "Kerbal Programa Espacial", 70.00f);

            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);
            cart.AdicionarProduto(p5);

            cart.MostrarProdutos();

           
        }
    }
}
