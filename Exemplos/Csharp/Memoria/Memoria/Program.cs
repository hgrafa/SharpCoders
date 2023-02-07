namespace Memoria {

    public class Program {

        static double Somar(double numero1, double numero2) {
            Console.WriteLine("Estou dentro da função somar");
            double soma = numero1 + numero2;
            Console.WriteLine("vou retornar a soma que calculei");
            return soma;
        }

        static void DizerOla(string nome) {
            Console.WriteLine($"Ola, {nome}!");
        }

        static void DizerOlaEResponderASoma(string nome, double x, double y) {
            DizerOla(nome);
            Console.WriteLine($"O valor da soma solicitado é {Somar(x, y)}");
        }

        public static void Main(string[] args) {
            /*
                        int[] vetor = { 1, 2, 3 };

                        int[] copy = vetor;

                        copy[1] = 900;


                        foreach (int elemento in vetor) {
                            Console.WriteLine(elemento);
                        }*/

            Console.WriteLine("Seja bem vindo ao nosso sistema!");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();


            Console.Write("Digite os valores a serem somados(na mesma linha): ");
            string[] linha = Console.ReadLine().Split();

            double valor1 = double.Parse(linha[0]);
            double valor2 = double.Parse(linha[1]);

            DizerOlaEResponderASoma(nome, valor1, valor2);

        }

    }

}

/*Estou dentro da funçao somar
vou retornar a soma que calculei
7*/