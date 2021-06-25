using System;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            string contato;
            string gmail;
            string ligacao;
            string mensagem;

            Celphone motorola = new Celphone();

            motorola.cor = "Preto";

            motorola.modelo = "MotorolaOne";

            motorola.tamanho = "5,8px";
            
            Console.WriteLine($"Este é seu celular:\n modelo: {motorola.modelo} \n Cor: {motorola.cor}  \n Tamanho: {motorola.tamanho}");

            Console.WriteLine("------------------------");

            do{

                Console.WriteLine("Este é o menu, selecione uma das opções abaixo para continuar o processo");

                Console.WriteLine("[1]- Ligue o Celular");
                Console.WriteLine("[2] - opções");
                Console.WriteLine("[3]- desligue o celular");
                resposta = int.Parse(Console.ReadLine());

                Console.Clear();

                switch(resposta)
                {
                    case 1:
                        Console.WriteLine("Estamos Preparando este celular para voçê, isso pode levar alguns minutos.");
                        Console.WriteLine("Digite seu Email ou Gmail:");
                        gmail = Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Você deseja fazer uma ligação?");
                        ligacao = Console.ReadLine();
                        
                        if(ligacao == "S")
                        {
                             
                            Console.WriteLine("Digite o contato que você deseja ligar");
                            contato = Console.ReadLine();
                            Console.WriteLine($"Ligando para: {contato}");
                                
                        }

                        Console.WriteLine("Deseja enviar uma mensagem para um contato seu?");
                        ligacao = Console.ReadLine();
                        
                        if (ligacao == "S")
                        {
                            Console.WriteLine("para qual contato deseja mandar uma mensagem?");
                            contato = Console.ReadLine();
                            Console.WriteLine($"Ok, envie a mensagem para {contato}");
                            mensagem = Console.ReadLine();
                        }else{
                            Console.WriteLine("Retornando ao menu.");
                        }
                    break;    
                        
                        
                }
            }while (resposta != 3);
        }
    }
}
