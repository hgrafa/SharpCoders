using System.Reflection.Metadata.Ecma335;

namespace FuncaoEVetores {

    public class Program {

        static void DobraVetor(int[] sequencia) {
            for(int i = 0; i < sequencia.Length; i++) {
                sequencia[i] *= 2; // sequencia[i] = sequencia[i] * 2
            }
        }

        static void Trocar(int firstValue, int secondValue) {
            int aux = firstValue;
            firstValue = secondValue;
            secondValue = aux;
        }

        static int Somar(int a, int b) => a + b;

        public static void Main(string[] args) {

            int[] vetor = new int[5];

            for(int i = 0; i < vetor.Length; i++) {
                vetor[i] = 3 * i;
            }

            foreach (int elemento in vetor) {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();

            DobraVetor(vetor);

            foreach(int elemento in vetor) {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------");
            int a = 5, b = 6;

            Trocar(a, b);

            Console.WriteLine($"A = {a} | B = {b}");

        }

    }

}

//0 3 6 9 12
//0 6 12 18 24
//----------------------------
//A = 5 | B = 6


//0 3 6 9 12
//0 6 12 18 24