using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{ //Esta classe esta vinculada com a classe membros
    class Pessoa  //tipo

    {    //2 atributos
        public string Nome; //string tem valor padrão NULL
        public int Idade; // int tem valor padrão 0. Segure Ctrl e 2 clics do mouse sobre int

        //abaixo 2 comportamentos
        public string Apresentar()
        {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()  
        {
            Nome = "";
            Idade = 0;
        }
    }
}
