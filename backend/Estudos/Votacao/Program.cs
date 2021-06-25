using System;

namespace Ano_de_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).*/
           
           Console.WriteLine("insira o ano atual");
           int anoAtual = int.Parse(Console.ReadLine());
           Console.WriteLine("Agora digite o ano de seu nascimento");
           int anoNascimento = int.Parse(Console.ReadLine());

           int retornoDaFuncao = idade(anoAtual,anoNascimento);
           ExibirMensagem(retornoDaFuncao);
           
           if(retornoDaFuncao >=18){
               Console.WriteLine("Adulto");
           }else{
               Console.WriteLine("infantil");
           }
           int idade(int atual, int nascimento){
               int idade = atual - nascimento;
               Console.WriteLine($"A idade é de {idade} ");
               return idade;
           }
           void ExibirMensagem(int idade){
               Console.WriteLine($"A idade é {idade} anos ");
           }

        }
    }
}
