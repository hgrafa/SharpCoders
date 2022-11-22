using System;

namespace OMaior_1013 {

    public class Program {

        public static void Main(string[] args) {

            string[] numeros = Console.ReadLine().Split();
            
            // default/padrão = separar por espaço

            // 2 3 4
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            int maior = (n1 + n2 + Math.Abs(n1 - n2)) / 2;
            
            maior = (maior + n3 + Math.Abs(maior - n3)) / 2;

            Console.WriteLine($"{maior} eh o maior"); // 106
        }

    }

}

