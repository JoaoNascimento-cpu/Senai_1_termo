namespace Personagem
{
    public class Character
    {
        public string nome = "Johnny";
        
        public int idade = 20;

        public string classe;

        public string armadura;

        public int vidaMason = 39;

        public int vidaSalazar = 32;

        public int atacarMason(){
            return 8;
        }

        public int especialMason(){
            return 10 * 2;
        }        
        
        public int atacarSalazar(){
            return 6;
        }

        public int bolaDeFogo(){
            return 6 * 6;
        }
        public string defenderMason(int ataque){
            this.vidaMason = this.vidaMason - ataque;
            return "mesmo após este ataque, Mason está de pé!!";
        }

        public string defenderSalazar(int ataque){
            this.vidaSalazar = this.vidaSalazar - ataque;
            return "mesmo após este ataque Salazar está de pé!!";
        }
    }
}