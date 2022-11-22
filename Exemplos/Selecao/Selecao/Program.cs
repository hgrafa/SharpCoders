using System.Runtime.Intrinsics.X86;

namespace Selecao {

    public class Program {

        public static void Main(string[] args) {

            int idade = int.Parse(Console.ReadLine());
            bool condicao = (idade > 23);

            if (condicao) {
                Console.WriteLine("Foi identificada uma idade ok!");
            }

            if(idade == 25) {
                Console.WriteLine("Tem 25 anos!");
            }

            if(idade == 35) {
                Console.WriteLine("Tem 35 anos!");
            }

            Console.WriteLine("Fim do programa!");

            // Foi identificada uma idade ok!
            // Tem 35 anos!
            // Fim do programa!

        }

    }

}