namespace Cartão_de_credito.classes
{
    public class cartão
    {
        private string numero;

        public string Numero
        {
            get{return numero;}
            set{numero = value;}
        }

        private string nomeTitular;

        public string NomeTitular
        {
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }

        private string bandeira;

        public string Bandeira
        {
            get{return bandeira;}
            set{bandeira = value;}
        }
        protected string token = "brasds";

        public string Token
        {
            get{return token;}
        }
        private string cvv;

        protected float limite = 5000;

        //métodos
        public string registrarCompra(bool validado)
        {
            return "";
        }

        public string receberNome(string nomeDigitado)
        {
            return this.nomeTitular = nomeDigitado;
        }

        public void exibirNome()
        {
            System.Console.WriteLine(this.nomeTitular);
        }
    }
}