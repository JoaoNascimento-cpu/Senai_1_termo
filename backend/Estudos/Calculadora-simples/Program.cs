using System;

namespace Projeto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //perguntaer operação 
            Console.WriteLine("qual operação deseja realizar? \n Soma, Subtracao, Multiplicacao e Divisao.");
            string operacao = Console.ReadLine() .ToLower();
            
            //pedir primeiro número
            Console.WriteLine("digite o primeiro numero.");
            float num1 = float.Parse( Console.ReadLine() );
            //pedir segundo número
            Console.WriteLine("Escreva o segundo numero");
            float num2 = float.Parse( Console.ReadLine() );
            //fazer o calculo
            float resultado = 0f;

            switch(operacao){
                case "soma":
                resultado = num1 + num2;
                break;

                case "subtração":
                resultado = num1 - num2;
                break;

                case "multiplicacao":
                resultado = num1 * num2;
                break;

                case "divisao":
                resultado = num1 / num2;
                break;

                default:
                Console.WriteLine("operacao invalida, tente novamente com outros codigos.");
                break;
            }
            //resultado
           Console.WriteLine($"Calculo: {num1} com {num2} = {resultado}");
        }   
        
    }
}
