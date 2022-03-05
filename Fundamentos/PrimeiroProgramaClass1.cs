using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class ProgramaClass1
    {
        public static void Executar() // em vez de Main por Executar
        {
            System.Console.WriteLine("Primeiro");/*Acima já está "using System", 
                                                  * portanto não é preciso por no 
                                                  * código repetidas vezes "System"*/
            Console.WriteLine("Programa");
            Console.WriteLine("Terminou!");
        }
    }
}
