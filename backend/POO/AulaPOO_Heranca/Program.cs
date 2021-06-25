using System;
using trabalho_2.classes;
namespace trabalho_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamento da subclasse "pessoa fisca"
            classes.PessoaFisica pf = new PessoaFisica();
            
            //atribuindo um objetivo ao CPF
            pf.cpf = "000.000.000-00";

            pf.nome = "Johnny";


            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            Console.WriteLine(pf.ValidarCPF(pf.cpf));
        }
    }
}
