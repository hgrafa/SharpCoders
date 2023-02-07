namespace ForEach {

    public class Program {

        public static void Main(string[] args) {

            int[] vetor = { 1, 2, 3, 4 };

            for(int i = 0; i < vetor.Length; i++) {
                vetor[i] = 2*i;
            }

            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = 2 * i;
            }

        }

    }

}

