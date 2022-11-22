namespace Nota {

    public class Program {

        public static void Main(string[] args) {

            double nota = 8.9;

            // [7.0 , 10.0]: aprovado
            // [4.0 , 7.0): recuperação
            // [0.0 , 4.0): reprovado


            if(nota == 10.0) {
                Console.WriteLine("excelente!");
            } else if ( nota >= 7.0 ) {
                Console.WriteLine("Aprovado!");
            } else if ( nota >= 4.0 ) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Reprovado");
            }

        }

    }

}