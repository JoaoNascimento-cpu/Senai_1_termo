using System;
using funcionarios.classes;

namespace funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func = new Funcionarios();
            func.Mostrar();
            func.Mostrar("Johnny");
            func.Mostrar(2);

            Console.Beep(900, 5000);
        }
    }
}
