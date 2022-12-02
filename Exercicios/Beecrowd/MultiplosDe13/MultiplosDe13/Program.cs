namespace MultiplosDe13 {

    public class Program {

        static int SomarDosMultiplosDe13(int inic, int fim) {
            int soma = 0;

            for (int i = inic; i <= fim; i++) {
                if (i % 13 != 0) soma += i;
            }

            return soma;
        }

        public static void Main (string[] args) {
        
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if(start > end) {
                int aux = start;
                start = end;
                end = aux;
            }

            Console.WriteLine( SomarDosMultiplosDe13(start, end) );

        }

    }
}

