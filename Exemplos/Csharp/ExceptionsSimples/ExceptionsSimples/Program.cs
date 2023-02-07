namespace ExceptionsSimples;

public class Program {

    public static void Main(string[] args) {

        string desejaContinuar = "y";

        do {

            Console.WriteLine("Dividindo...");
            double a;
            double b;
            try {

                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                if (b == 0) {
                    throw new DivideByZeroException("Ops! Parece que você tentou dividir por zero.");
                }

                Console.WriteLine(a / b);
            } catch (DivideByZeroException byZeroException) {
                Console.WriteLine(byZeroException.Message);
            } catch (FormatException) {
                Console.WriteLine("O conteúdo digitiado não está no formato correto");
            }

            Console.WriteLine("Deseja continuar? (y / n)");
            desejaContinuar = Console.ReadLine();

        } while (desejaContinuar == "y");

        Console.WriteLine("meu código agora pode terminar tranquilo!");

    }

}