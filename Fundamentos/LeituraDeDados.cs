using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LeituraDeDados
    {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());//Parse é para converter, há formas mais seguras

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);/* vai passar ponto para virgula,
                                               * usar no cabeçalho: using System.Globalization;*/ 
            
            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
