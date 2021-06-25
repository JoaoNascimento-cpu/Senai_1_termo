namespace Polimorfismo.classes
{
    public abstract class Jogador
    {
        public virtual void Correr()
        {
            System.Console.WriteLine("O jogador corre na velociadade 12");
        }

        public virtual void Pular()
        {
            System.Console.WriteLine("O jogador pula 1 metro de altura");
        }
    }
}