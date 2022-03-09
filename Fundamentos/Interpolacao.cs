using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            var nome = "Computer Gamer"; //string
            var marca = "Dell";
            var valor = 2_757.97; //double
            Console.WriteLine("O "+nome+" da marca "+marca+" custa R$"+valor+".");//concatenação
            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, valor);
            Console.WriteLine($"A marca {marca} é boa.");
            Console.WriteLine($"1 + 1 = {1 + 1}"); // $ é para ativar a interpolação
        }
    }
}
