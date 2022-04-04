using System;
using System.Collections;
using System.Collections.Generic; // usar

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar() {
            var fila = new Queue<string>(); //   <string>  isso é um generics

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Peek pega o intem da lista sem remover
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // desinfileirar
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);             /// fila dinâmica
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); // i minúsculo
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
