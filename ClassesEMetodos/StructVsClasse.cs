using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct StructPonto
    { 
        public int X;
        public int Y;
    }

    public class ClassePonto {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar() {
            StructPonto ponto1 = new StructPonto { X = 1, Y = 3 }; /// STRUCT
            StructPonto copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            ClassePonto ponto2 = new ClassePonto { X = 2, Y = 4 };   ///CLASSE
            ClassePonto copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }

}