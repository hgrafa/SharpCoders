namespace NumerosPrimos_1165 {

    public class Program {

        static bool isPrime(int value) {

            if (value == 1) return false;

            for(int i = 2; i < value; i++) {
                if (value % i == 0)
                    return false;
            }

            return true;
        }

        public static void Main(string[] args) {

            int quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++) {
                int numero = int.Parse(Console.ReadLine());

                string resp = $"{numero} ";
                if (!isPrime(numero)) resp += "nao ";
                resp += "eh primo";

                Console.WriteLine(resp);
            }

        }

    }

}