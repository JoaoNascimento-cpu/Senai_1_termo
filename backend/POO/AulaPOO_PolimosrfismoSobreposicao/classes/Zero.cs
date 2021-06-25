namespace Polimorfismo.classes
{
    public class Zero : Jogador
    {
        public override void Correr()
        {
            base.Correr();
        }

        public override void Pular()
        {
            System.Console.WriteLine("O jogador pula 3 metros de altura");
        }
    }
}