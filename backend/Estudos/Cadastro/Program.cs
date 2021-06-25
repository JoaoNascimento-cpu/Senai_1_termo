using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args) 
            
        {
            Console.WriteLine("Digite seu nome de usuário e sua senha");
            Console.WriteLine("-----------------------------------------------");

            string nomedeusuario;
            string senha;

            do{
                Console.WriteLine("Digite seu nome de usuário");
                nomedeusuario = Console.ReadLine() .ToLower();

                Console.WriteLine("Ok, agora digite sua senha");
                senha = Console.ReadLine() .ToLower();

                if(nomedeusuario == senha){
                    Console.WriteLine("Seu nome de usuário ou senha estão incorretos");
                    Console.WriteLine("--------------------------------------------------------"); 
                }

                
            }while(nomedeusuario == senha);

            Console.WriteLine("Cadastro realizado com sucesso");


        }
    }
}
