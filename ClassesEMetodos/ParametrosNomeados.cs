using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);//O zero caso tenha 1 digito
                                                                  //D2 para casas decimais
                                                                  //ordenado corretamente
        }

        public static void Executar() {
            Formatar(mes: 1, ano: 1996, dia: 6 ); //Os parâmetros estão nomeados, por isso
                                                  //a ordem arrada aqui não vai inteferir
        }
    }
}
