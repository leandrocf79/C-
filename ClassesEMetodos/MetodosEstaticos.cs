using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        ///Esse método é de CLASSE ou ESTÁTICO!
        
        // static diz que pode acessar diretamente sem criar instância
        //não pertence mais ao objeto, mas sim à classe 
        //           pode ser compartilhado!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de instância!!!
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine("Resultado, multiplicar: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Soma: " + calc.Somar(2, 7));
            //Console.WriteLine(calc.Multiplicar(2, 7));     // desse modo vai dar erro
                                                             //tem que acessar pela classe
        }
    }
}
