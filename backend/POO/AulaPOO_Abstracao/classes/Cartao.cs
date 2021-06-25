namespace abstração.classes
{
    public abstract class Cartao : pagamento
    {
        public string bandeira;

        public string numero;

        public string titular;

        public string cvv;

        public override string Desconto(int valor)
        {
            return "";
        }

        public override string juros(int parcelas)
        {
            return "";
        }

        public string salvarCartao()
        {
            return "";
        }
    }
}