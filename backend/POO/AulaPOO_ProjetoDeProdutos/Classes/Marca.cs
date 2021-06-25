using System;
using System.Collections.Generic;

namespace Produtos.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro {get; set;}
        public List<Marca> ListaDeMarcas = new List<Marca>();
        

        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();
            Console.WriteLine("Digite o código da marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine( ) );

            Console.WriteLine("Digite o nome da Marca");
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;
            
            ListaDeMarcas.Add(novaMarca);
            return novaMarca;
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (Marca item in ListaDeMarcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");

            }
                Console.ResetColor();
        }        

        public void Deletar(int cod)
        {
            Marca marcaDelete = ListaDeMarcas.Find(x => x.Codigo == cod);
            ListaDeMarcas.Remove(marcaDelete);
        }
    }
}