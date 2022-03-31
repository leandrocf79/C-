using System;
//using System.Collections.Generic;      *não precisa declarar por já estar dentro 
//using System.Text;                      da mesma classe Pessoa*

namespace CursoCSharp.ClassesEMetodos
{ //Esta classe esta vinculada com a classe Pessoa
    class Membros /*esta aula mostra a possibilidade de criar varios arquivos dentro
                   * do mesmo namespace, sem ter que abrir novos arquivos, é apenas 
                   * uma questão de organização.*/
    {
        public static void Executar() {

            //clsse              construtor     diferenças entre as palavras Pessoas
                        Pessoa sicrano = new Pessoa();//Segure Ctrl e clicar sobre pessoa
            sicrano.Nome = "Leandro";
            sicrano.Idade = 42;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Jaspion";
            fulano.Idade = 57;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
