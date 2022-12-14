namespace Matrizes {

    public class Program {

        public static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas e colunas: ");
            string[] input = Console.ReadLine().Split();
            int nLinhas = int.Parse(input[0]);
            int nColunas = int.Parse(input[1]);

            Console.WriteLine($"Linhas = {nLinhas} | Colunas = {nColunas}");

            int[,] matriz = new int[nLinhas, nColunas];

            for (int i = 0; i < nLinhas; i++) {
                // lendo linha por linha
                input = Console.ReadLine().Split();

                for (int j = 0; j < nColunas; j++) {
                    // quebando a linha pelas colunas da matriz
                    matriz[i, j] = int.Parse(input[j]);
                }
            }

            for(int i = 0; i < nLinhas; i++) {
                for(int j = 0; j < nColunas; j++) {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }                        

        }

    }

}