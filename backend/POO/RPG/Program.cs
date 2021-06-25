using System;

namespace Personagem
{
    class Program
    {
        static void Main(string[] args)
        {
            var dado = new Random();

            Character Johnny = new Character();
            Johnny.nome = "Mason";
            Johnny.idade = 32;
            Johnny.armadura = "Peitoral";
            Johnny.classe ="Guerreiro";

            Character Robert = new Character();

            Robert.nome = "Salazar";
            Robert.classe = "Mago";
            Robert.idade = 30;
            Robert.armadura = "Escudo arcano";
            
            Console.WriteLine($"Agora na arena de Velen veremos o grande guerreiro {Johnny.nome} lutando contra o implacável {Robert.classe} {Robert.nome}");
            Console.WriteLine($"O grande {Johnny.nome} usando o seu {Johnny.armadura} e o implacável {Robert.nome} com poucas vestimentas e seu {Robert.armadura}");
            Console.WriteLine("Qual dos dois irá ganhar essa grande batalha? \n COMECEM!!");
            Console.WriteLine("-------------------------");
            //Console.WriteLine(Johnny.atacar());

            Robert.defenderSalazar(Robert.especialMason());

            Console.WriteLine($"{Robert.nome} depois deste ataque ficou com {Robert.vidaSalazar} de vida");
        }
    }
}
