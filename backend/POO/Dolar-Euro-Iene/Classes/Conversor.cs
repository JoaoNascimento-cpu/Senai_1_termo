namespace DolarEuroIene.Classes
{
    public static class Conversor
    {

        public static string respostaMenu;
        private static float cotacaoDolar = 5.11f;
        private static float cotacaoEuro = 6.21f;
        private static float cotacaoIene = 0.049f;

        public static float RealParaDolar(float valorRS)
        {
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorUS)
        {
            return cotacaoDolar * valorUS; 
        }

        public static float RealParaEuro(float valorRS)
        {
            return valorRS / cotacaoEuro;
        }

        public static float EuroParaReal(float valorEU)
        {
            return valorEU * cotacaoEuro;
        }

        public static float IeneParaReal(float valorRS)
        {
            return valorRS / cotacaoIene;
        }

        public static float RealParaIene(float valorYEN)
        {
            return valorYEN * cotacaoIene;
        }
    }
}