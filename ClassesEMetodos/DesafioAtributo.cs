using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        int b = 11;
        // Uma outra forma seria:   static int b = 11;
        // e dentro de executar:    Console.WriteLine(b);
        int c = 12;

        public static void Executar() {
            // Acessar variável 'b' dentro do método Executar!
            // Console.WriteLine(b);

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.b);
        }
    }
}
