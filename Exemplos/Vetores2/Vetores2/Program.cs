namespace Vetores2 {

    public class Program {

        public static void Main(string[] args) {

            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];

            for(int i = 0; i < tamanho; i++) {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;

            for(int i = 0; i < tamanho; i++) {
                soma += vetor[i];
            }

            Console.WriteLine($"Soma = {soma}");

        }

    }

}