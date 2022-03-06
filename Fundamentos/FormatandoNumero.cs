using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//unica casa decimal após vírgula
            Console.WriteLine(valor.ToString("C"));//passa para valor monetário do sistema
            Console.WriteLine(valor.ToString("P"));//converte e poe o símbolo de porcentagem
            Console.WriteLine(valor.ToString("#.##"));// 2 casas decimais, mas poderia ter colocado F2

            CultureInfo cultura = new CultureInfo("en-US"); // torna fixo o símbolo
            Console.WriteLine(valor.ToString("C0", cultura));
            Console.WriteLine(valor.ToString("C2", cultura));
            //CultureInfo cultura = new CultureInfo("pt-BR");
            //Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
