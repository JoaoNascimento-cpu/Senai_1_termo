using System;

namespace Name.Classes
{
    public class Pessoa
    {
        public string primeiroNome;
        public string sobreNome;

        public Pessoa(string primeiroNome, string sobreNome)
        {
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;
            Console.WriteLine($"Bem vindo(a) {primeiroNome} {sobreNome}");
        }
    }
}