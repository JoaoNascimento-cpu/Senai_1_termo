using System;
using DolarEuroIene.Classes;
namespace Dolar__Euro__Iene
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            
            Console.WriteLine("Bem vindo a Johnny's today's economy.");
            
            Console.WriteLine("----------------------------------------");
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;   
                Console.WriteLine("Qual moeda você deseja comparar com Real?");
                Console.WriteLine("[1] - Dolar.");
                Console.WriteLine("[2] - Euro.");
                Console.WriteLine("[3] - Iene.");
                Console.WriteLine("[4] - Sair do Site.");
                Conversor.respostaMenu = Console.ReadLine();

                switch (Conversor.respostaMenu)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite o valor que deseja calcular de real para dolar:");
                        Console.WriteLine(Conversor.RealParaDolar(float.Parse(Console.ReadLine( ) ) ) );
                        Console.WriteLine("Agora digite um valor de Dolar para Real:");
                        Console.WriteLine(Conversor.DolarParaReal(float.Parse(Console.ReadLine( ) ) ) );
                        Console.WriteLine("Retornando ao Menu.");
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Digite o valor que deseja calcular de Real para dolar:");
                        Console.WriteLine(Conversor.RealParaEuro(float.Parse(Console.ReadLine() ) ) );
                        Console.WriteLine("Agora digite um valor para converter de Euro para Real:");
                        Console.WriteLine(Conversor.EuroParaReal(float.Parse(Console.ReadLine() ) ) );
                        Console.WriteLine("Retornando ao Menu.");
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Digite o valor que deseja calcular de real para Iene:");
                        Console.WriteLine(Conversor.IeneParaReal(float.Parse(Console.ReadLine( ) ) ) );
                        Console.WriteLine("Agora digite um valor de Iene para Real:");
                        Console.WriteLine(Conversor.RealParaIene(float.Parse(Console.ReadLine( ) ) ) );
                        Console.WriteLine("Retornando ao Menu.");
                        break;        
                    default:
                        Console.WriteLine("Saindo do Site.");
                        break;
                        
                }
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }while (Conversor.respostaMenu != "4");
            

            // //Dolar
            // Console.WriteLine(Conversor.DolarParaReal(1));
            // Console.WriteLine(Conversor.RealParaDolar(5));
            // //Euro
            // Console.WriteLine(Conversor.EuroParaReal(1));
            // Console.WriteLine(Conversor.RealParaEuro(6));
            // //Iene
            // Console.WriteLine(Conversor.IeneParaReal(1));
            // Console.WriteLine(Conversor.RealParaIene(2));
        }
    }
}
