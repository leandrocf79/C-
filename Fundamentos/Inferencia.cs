using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "Meu nome é Leandro.";//O var vai converter para string implicitamente
            Console.WriteLine(nome);

            //int idade = 42; ou 
            var idade = 42;
            Console.WriteLine("Minha idade é "+idade+" anos");

            int a;
            a = 2;
            var b = 5;
            Console.WriteLine("A + B = "+ (a+b));

        }
    }
}
