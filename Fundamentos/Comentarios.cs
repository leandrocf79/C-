using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Comentarios
    {
        public static void Executar()
            //evitar comentários desnecessários
        {
            Console.WriteLine("Código limpo é sempre melhor");
            Console.WriteLine("O C# tem xml coments: ///");
            /// XML COMENTS para gerar tag
            /// Pode fazer referências para outras partes da documentação
            /// Precione Ctrl+espaço
            ///
            /*Existem também os
             * comentários óbvios, quando o nome de uma 
             * varioável já diz todo o necessário para o entendimento dela.
             */
            //Pode usar atalho padrão: Selecionar e Ctrl+K+c e Ctrl+k+u
        }
    }
}
