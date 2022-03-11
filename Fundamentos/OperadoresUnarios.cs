using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;
            Console.WriteLine("valorNegativo = -5; booleano = true; numero1 = 2; numero2 = 3;  \n******************");

            Console.WriteLine("-valorNegativo: ");
            Console.WriteLine(-valorNegativo);
            Console.WriteLine("!booleano: ");
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine("numero1++ (incremento): ");
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine("--numero1 (decremento): ");
            Console.WriteLine(numero1);

            Console.WriteLine("\n(numero1++ == --numero2):");
            Console.WriteLine(numero1++ == --numero2);/* para BOAS PRÁTICAS evitar esse tipo de
                                                       * algorítmo, misturando muitas coisas.*/
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
