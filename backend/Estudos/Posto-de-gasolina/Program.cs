using System;

namespace Posto_de_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2, posto de gasolina");

            Console.WriteLine("Qual o tipo de combustivel? G-Gasolina, ou A-Alcool");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de litros que deseja abastecer");
            float litro = float.Parse(Console.ReadLine());
            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;
            float resultadoDaFuncao;
            //declaração desconto
          
            switch (tipo.ToLower( ) )
            {
                case "a":
                        resultadoDaFuncao = valorASerPago(litro, precoAlcool, 0.03f, 0.05f);
                        Console.WriteLine($"O valor a ser pago pelo alcóol é de: {resultadoDaFuncao}");
                break;
                case "g":
                        resultadoDaFuncao = valorASerPago(litro, precoGasolina, 0.04f, 0.06f);
                        Console.WriteLine($"O valor a ser pago pela gasolina é de: {resultadoDaFuncao} ");
                break;                   
                default:
                    Console.WriteLine("Valor inválido.");
                    break;
                }//fim swicth  
              float valorASerPago(float litro, float preco, float perc1, float perc2){
                    float percentualDesconto;
                    if(litro <= 20){
                        percentualDesconto = perc1;
                    }else{
                        percentualDesconto = perc2;
                    }
                    float totalDesconto = (litro * preco) * percentualDesconto;
                    float valorBruto = (litro * preco);
                    float valorAPagar = valorBruto - totalDesconto;
                    return valorAPagar;
                }
            
        } //fim do main
    }
}    