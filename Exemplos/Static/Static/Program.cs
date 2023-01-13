using Static.Entity;
using Static.Entity.Enums;

namespace Static {

    public class Program {

        public static void Main(string[] args) {

            Circulo c1 = new Circulo(0.3, 3.0, Color.VERDE);
            Circulo c2 = new Circulo(0.3, 3.0, Color.AZUL);

            Console.WriteLine(Color.VERDE.ToString()); // VERDE
            Console.WriteLine();
            

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());

            Console.WriteLine(c1.Equals(c2));

            Console.WriteLine();

            Console.WriteLine(c1); // Static.Entity.Circulo

        }

    }

}

