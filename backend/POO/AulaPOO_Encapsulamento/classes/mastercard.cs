namespace Cartão_de_credito.classes
{
    public class mastercard : cartão
    {
        private int parcelas;

        public void exibirLimite()
        {
            System.Console.WriteLine(this.limite);
        }

       
    }
}