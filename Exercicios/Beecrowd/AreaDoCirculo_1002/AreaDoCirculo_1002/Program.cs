using System;

namespace AreaDoCirculo_1002 {

    public class Program {

        public static void Main(string[] args) {

            double PI = 3.14159;
            double raio;

            raio = double.Parse(Console.ReadLine());
            double area = PI * raio * raio;

            Console.WriteLine($"A={area:F4}");
        }

    }

}

// A = 12.56636
// A = 12.5664