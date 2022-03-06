using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao= "olá".ToUpper().Insert(3," world!").Replace("world!","mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine("Leandro".Length); //Ctrl + espace após o ponto
            Console.WriteLine("A palavra 'Leandro' tem " +("Leandro".Length)+" letras");
            
            string valorImportante = null;
            Console.WriteLine(valorImportante.Length);// VAI RETORNAR ERRO devido ao valor vazio
            Console.WriteLine(valorImportante?.Length);/* O "?" vai fazer aguardar 
                                                        * algum valor na variável e vai 
                                                        * imprimir na tela um espaço de uma 
                                                        * linha vazia*/

        }
    }
}
