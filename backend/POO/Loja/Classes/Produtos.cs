using System;

namespace Loja.Classes
{
    public class Produtos
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }

        public string Descricao { get; set; }
        
        public int Estoque { get; set; }

        public Produtos(int codigo, string nome, string descricao, int estoque)
        {
            if (codigo < 10)
            {
                Console.WriteLine("Valor inválido");
            }else
            {

            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;

            Console.WriteLine($"Produto cadastradocom sucesso, código - {Codigo} Nome- {Nome}");
            }
        }

        public Produtos(int codigo)
        {
            if(codigo >= 0)
            {
                Codigo = codigo;
                Nome = "coquinha";
                Console.WriteLine($"Produto cadastrado com sucesso, código - {Codigo} -Nome {Nome ?? "Sem nome"}");
            }else
            {
                Console.WriteLine("Codigo inválido.");
            }

        }
    }
}