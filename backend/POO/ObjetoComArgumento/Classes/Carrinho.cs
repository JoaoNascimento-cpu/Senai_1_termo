using System;
using  System.Collections.Generic;
namespace objetoArgumento.Classes
{
    public class Carrinho
    {
        public string resposta;
        public float ValorTotal {get; set;}

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor(); 
                }
                MostrarTotal();
            }else
                {
                    Console.WriteLine("Seu carrinho está vazio");
                }
        }

        public void RemoverProduto(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void MostrarTotal()
        {
            if(carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    ValorTotal =+ item.Preco;
                }
                Console.WriteLine($"O valor de seu carrinho é: R$:{ValorTotal}");
            }else
            {
                Console.WriteLine("Seu carrinho está vazio.");
            }
        }

        public void AlterarItem(int _codigo, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo);
        }
    }
}