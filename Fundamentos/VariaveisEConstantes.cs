using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Área da circunferência
            double raio = 4.5;
            const double Pi = 3.14159;
            double area = Pi * raio * raio;
            Console.WriteLine("Área 1: "+ area);
            Console.WriteLine("Área 2: "+ area + 1000); 
            Console.WriteLine("Área 3: " + (area+1000) + " m2");

            bool EstaChovendo = false;
            Console.WriteLine("Está chovendo: " + EstaChovendo);

            byte idade = 45; //não aceita número negativo,
                             //menor recurso de memória comparado ao int
            Console.WriteLine("Idade: "+ idade);
            
            sbyte SaldodeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols: "+ SaldodeGols);

            short Salario = short.MaxValue;
            Console.WriteLine("Salario :"+Salario);

            int menorValorInteiro = int.MinValue; // mais usado dos inteiros
            Console.WriteLine("Menor valor inteiro: "+menorValorInteiro);

            uint populancaoBrasileira = 230_000_000;//underline é apenas visual, ajuda a visualizar 
            Console.WriteLine("População brasileira: "+populancaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long: "+menorValorLong);

            ulong populacaoMundial = 7_500_000_000;
            Console.WriteLine("População mundial: "+populacaoMundial);

            float precoComputador = 1_345.98f;
            Console.WriteLine("Preço do Computador: "+precoComputador);

            var precoComputador2 = 1_345.98;
            Console.WriteLine("Teste VAR: "+ precoComputador2);

            double valorApple = 1_000_000_000_000;
            Console.WriteLine("Valor empresa Apple: "+ valorApple);

            decimal distanciaEntreEstrelas=decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas: "+distanciaEntreEstrelas);

            char letra = 'b';//aspas simples é somente para UMA letra
            Console.WriteLine("Letra: "+letra);

            string texto = "Sean bienvenidos";
            Console.WriteLine("Texto: "+texto);

        }

    }
}
