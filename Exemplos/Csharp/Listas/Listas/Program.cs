using System.Collections.Generic;

namespace Listas {

    public class Program {

        public static void Main(string[] args) {

            List<int> sequencia = new List<int>();
/*            int? nota = null;
            int nota = null;*/

            sequencia.Add(2);
            sequencia.Add(3);
            sequencia.Add(4);

            sequencia.RemoveAt(0);

            Console.WriteLine("Tamanho da lista = " + sequencia.Count);

            Console.WriteLine("Contem 2? " + sequencia.Contains(2));

            sequencia.Add(2); // 3, 1, 4, 2
            sequencia.Insert(1, 99);

            sequencia.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();

            List<int> lista2 = new List<int>();

            lista2.Add(9);
            lista2.AddRange(sequencia);

            var result = sequencia.Find(x => x % 2 == 0);
            Console.WriteLine(result);

            Console.WriteLine("------------------------");

            var result2 = sequencia.Where(x => x % 2 == 0);
            foreach(var elemento in result2) {
                Console.WriteLine(elemento);
            }
            Console.WriteLine("------------------------");

            var result3 = sequencia.FindAll(x => x % 2 == 1);
            result3.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();

            Console.WriteLine("------------------------");

            // sequencia.RemoveRange(1, 3);
            var result4 = sequencia.RemoveAll(x => x > 10);
            Console.WriteLine("numero de elementos removidos: " + result4);
            Console.WriteLine("------------------------");

            for(int i = 0; i < sequencia.Count; i++) {
                Console.WriteLine(sequencia[i]);
            }

            Console.WriteLine("------------------------");
            var result5 = sequencia.Select(x => x*1.1);
            foreach(var element in result5) {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------");

        }

    }

}