namespace Enquanto {

    public class Program {

        public static void Main(string[] args) {

            int estoque = -50;
            int quantidadeMinima = 7;

            Console.WriteLine($"Nossa loja abriu! Estoque inicial = {estoque}");

            while (estoque != 0) {
                if (estoque > 0) {
                    estoque--;
                    Console.WriteLine($"Continuo vendendo, estoque = {estoque}");
                } else {
                    estoque += quantidadeMinima;
                    Console.WriteLine($"Preciso repor o estoque... estoque = {estoque}");
                }
            }

            Console.WriteLine($"Estoque = {estoque}");
            Console.WriteLine("O estoque zerou");
            Console.WriteLine("Podemos fechar nossa loja");

        }

    }

}