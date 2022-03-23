using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s"; /*Essa estrutura substitui as outras
                                                          *3 acima, já cria uma estrutura de valor
                                                          *lógico e passa o dígito para minusculo*/

            if (nota >= 9.0 && bomComportamento)/*nunca por ; aqui*/
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
