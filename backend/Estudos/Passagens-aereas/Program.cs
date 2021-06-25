using System;

namespace Cadastro_passagens_aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Bem vindo a Johnny AirLines! Agora iniciaremos seu cadastro");
            Console.WriteLine("----------------------------------");
            
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            //dados da passagem
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string [5];
            string[] data = new string[5];



            //processamento login
            do{
                Console.WriteLine("Digite a senha para poder acessar o cadastramento do usuário:");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            }while (!senhaValida);

            //menu
            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo");
                
                Console.WriteLine("[1} - Cadastrar Passagem");

                Console.WriteLine("[2] - Listar passagens");

                Console.WriteLine("[0] - Sair do programa");

                escolha = int.Parse(Console.ReadLine( ) );

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastrar passageiro");
                        do
                        {
                            if(contador <5){

                            Console.WriteLine($"Digite os nome do {contador+1}° passageiros");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino:");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a origem");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine("Digite a data do voo");
                            data[contador] = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Limite excedido");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar um novo passageiro? S/N");
                            resposta = Console.ReadLine();
                        } while (resposta.ToUpper() == "S");
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Listar passagem");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro {nomes[i]} data do voo {data[i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por viajar na johnny AirLines.");
                        break;        
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (escolha != 0);

            //funções
            bool EfetuarLogin(string senha){
                if(senha == "696924"){
                    Console.WriteLine("Senha válida");
                    return (true);
                }else{
                    Console.WriteLine("Senha inválida, tente novamente.");
                    return(false);
                }
            }

        }
    }
}
