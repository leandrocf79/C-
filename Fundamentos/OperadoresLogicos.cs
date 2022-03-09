using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = true;
            Console.WriteLine("Vai trabalhar  2 dias esta semana e ir às compras,\n" +
                "se entregar os trabalhos e receber em 1 ou nos 2, ou nem receber,\n" +
                "como ficam os casos abaixo? ");
            
            Console.WriteLine("\nUm e outro:");
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            Console.WriteLine("\nUm ou outro:");
            var comprouSorvete = executouTrabalho1 || executouTrabalho2; //  ||  ou condicional
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            Console.WriteLine("\nOu um, ou outro:");
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //  ^  ou exclusivo
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("\nEconomizou em gartar com sorvete? {0}", !comprouSorvete); //  ! inverte saída
        }
    }
}
