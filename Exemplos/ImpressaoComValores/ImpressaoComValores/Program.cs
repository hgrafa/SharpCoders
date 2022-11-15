namespace ImpressaoComValores {
    public class Program {
        public static void Main(string[] args) {

            // concatenação
            int idade = 21;
            Console.WriteLine("A idade é " + idade);

            // interpolação
            string nomeDaTurma = "Sharp Coders";
            int anoDeInicio = 2022;
            Console.WriteLine($"O nome da turma é {nomeDaTurma} começando em {anoDeInicio}");

        }
    }
}