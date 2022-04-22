using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima; // readonly para manter fixa a informação
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        { //Protected para ocultar do usuário
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {      //limitar erros na correção da nova velocidade
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }


        // aceleração e frenagem padrão, pode ser alterado se por "virtual"
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5); // velocidada será alterada de 5 em 5
        }

        public int Frear()
        {
            return AlterarVelocidade(-5); // velocidada será alterada de 5 em 5
        }
    }




    public class Uno : Carro
    {
        public Uno() : base(200)
        {
            // sem construtor padrão usar  :  e acrescentar informação
        }
    }



    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            //override sobrescrever um método já definido para este caso
            // Ferrari tem aceleração mais rápida que o Uno
            return AlterarVelocidade(15);
            //pode ser alterado se por "virtual" no método padrão
            //public     virtual     int Acelerar()
        }

       

        public new int Frear()
        // new vai ocultar o método da classe Pai,
        // é uma outra forma de se fazer a ideia acima,
        // mas tem diferença de comprtamento. Polimorfismo
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari();// Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
