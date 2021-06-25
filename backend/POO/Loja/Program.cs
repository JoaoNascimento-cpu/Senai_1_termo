using System;
using Loja.Classes;
namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto = new Produtos(10, "XRatão", "Coquinha gelada", 10);

            Produtos produto1 = new Produtos(8);
        }
    }
}
