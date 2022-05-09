using System;

namespace Reino
{

    public class Animal //exercício com conteúdos irrelevantes
                        //Apenas praticando C#. 
    {
        string nome;
        bool quadrupede;
        string cor;
        internal void cadastro(string N, bool Q, string C)
        {
            nome = N;
            quadrupede = Q;
            cor = C;
        }
        internal void imprimir()
        {
            Console.WriteLine($"Nome: "+nome + ".\t\tQuadrupede: "+quadrupede + ".\t\tCor: "+cor +".");

        }

    }

    public class inserirAnimais
    {
        public static void Main( string[] args )
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            Animal animal3 = new Animal();
            Animal animal4= new Animal();
           
            animal1.cadastro("Cabra A13", true, "Marrom" );
            animal2.cadastro("Gavião SA", false, "Variada");
            animal3.cadastro("Elefante A2", true, "Cinza");
            animal4.cadastro("Cavalo B4", true, "Marrom");

            animal1.imprimir();
            animal2.imprimir();
            animal3.imprimir();
            animal4.imprimir();
            
        }
    }
}