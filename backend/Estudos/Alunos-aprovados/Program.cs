using System;

namespace Alunos_e_notas
{
    class Program
    {

        static float CalcularMedia( float[] numeros ){
            float soma = 0;
            for(var i = 0; i< numeros.Length; i++)
            {
                soma += numeros[i];
            }

            float resultado = soma / numeros.Length;

            return resultado;
        }

        static void Main(string[] args)
        {
            /*1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
            A. A Média do aluno - Função
            B. A quantidade de Aprovados (Média >=7)
            C. A quantidade de Reprovados (Méida < 7)
            D. A Média geral dos 10 alunos.*/

            string[] nomes = new string [10];
            float[] media = new float[10];
            float[] nota = new float [4];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("----------------------");
                Console.Write("digite o nome do aluno:");
                nomes[i] = Console.ReadLine();

                for (int n = 0; n < nota.Length; n++)
                {
                    Console.WriteLine($"Digite a nota {(n+1)} do aluno");
                    nota[n] = float.Parse(Console.ReadLine());
                }
                
                media[i]= CalcularMedia(nota);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;

            //laços condicionais
            foreach(string nomeavulso in nomes){
                Console.WriteLine(nomeavulso);
            }

            //mostrando a informações
            for (var i = 0; i < nomes.Length; i++)
            {
                //interpolação
                Console.WriteLine($"Nome: {nomes[i]} Média: {media[i]} ");
            }

            Console.ResetColor();

            Console.WriteLine("Média geral da turma: " +CalcularMedia(media));
        }
    }
}
