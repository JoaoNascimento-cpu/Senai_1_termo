namespace Polimorfismo.classes
{
    public class Megamen : Jogador
    {
        public override void Correr()
        {
            System.Console.WriteLine("O jogador corre na velociade 15");
        }

        public override void Pular()
        {
            base.Pular();
        }
    }
}