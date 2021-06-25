namespace abstração.classes
{
    public class Boleto : pagamento
    {
        public string CodigoDeBarras;

        public string codigodebarras
        {
            get{return CodigoDeBarras;}
        }

        public void  Registrar(string valor)
        {
            this.CodigoDeBarras = valor;
        }

        public override string Desconto(int valor)
        {
            return "";
        }

        public override string juros(int parcelas)
        {
            throw new System.NotImplementedException();
        }
    }
}