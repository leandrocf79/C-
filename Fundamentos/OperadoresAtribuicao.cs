using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7; // aqui o valor foi substítuido
            num1 += 10; // é a mesma coisa que: num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;  incremento
            b--; // b = b - 1;  decremento

            Console.WriteLine($"{a} {b}");// $ é para ativar a interpolação de a e b


            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
            Console.WriteLine(d.nome);
        }
    }
}
