using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto {
        private string Marca;
        private string Modelo; // se deixar sem o private ele já estará automaticamente
        private uint Cilindrada;
        //get vai ler
        //set vai modificar um valor private 

        public Moto(string marca, string modelo, uint cilindrada) { //uint é sem sinal,
                                                                  //não permite nº negativo
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() { // Existem algoritmos melhores que esse, ver em Props

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) { // recebe novos parâmetros
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() { //uint é sem sinal, não permite número negativo
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) { //uint é sem sinal
            // 1 Opção
            //if(cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            // 2 Opção
            //Cilindrada = Math.Abs(cilindrada);   para tirar valores negativos

            Cilindrada = cilindrada;
        }
    }

    class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca()); // esse é meio de acessar por estar private
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150); // o valor negativo não vai ser aceito
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo()
                + " " + moto2.GetCilindrada());
        }
    }
}
