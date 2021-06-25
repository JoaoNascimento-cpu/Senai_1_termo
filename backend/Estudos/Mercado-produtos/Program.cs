using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada
            Console.WriteLine("--------------------------");
            Console.WriteLine("Bem vindo a Johnny's Market delivery, qual produto deseja cadastrar no nosso menu?");
            Console.WriteLine("--------------------------");
            //variaveis
            string[] produto = new string[10];
            float preco;
            float escolha;
            int contador = 0;
            string resposta;

            //processamento
            do
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("Escolha uma das opções a seguir para determinar oque deseja realizar");

                Console.WriteLine("Digite [1] para adicionar algum produto a sua sacola");
                Console.WriteLine("Digite [0] para cancelar esta operação");

                escolha = int.Parse(Console.ReadLine( ) );

                switch (escolha)
                {
                    case 1:
                            Console.WriteLine("Adicione o produto na sacola");
                            do
                            {
                                if(contador < 10)
                                {
                                    Console.WriteLine($"digite o nome do {contador+1} produto");
                                    produto[contador] = Console.ReadLine();
                                    Console.WriteLine("Agora digite seu preço:");
                                    preco = int.Parse(Console.ReadLine());
                                    contador++;
                                }else{
                                    Console.WriteLine("Valor excedido");
                                    break;
                                }
                                Console.WriteLine("Deseja adicionar mais um produto? 'S'/'N'");
                                resposta = Console.ReadLine();
                        } while(resposta.ToUpper() == "S");
                    break;
                    case 0:
                        Console.WriteLine("Por que entrou?? Some daqui.");
                        break;
                }
                           

            }while(escolha != 0);           
        }
    }
}
