using System;

namespace abstração.classes
{
    public abstract class pagamento
    {
        private DateTime data;

        protected float valor;

        public string Cancelar()
        {
            return "";
        }

        public abstract string Desconto(int valor);

        public abstract string juros(int parcelas);
    }
}