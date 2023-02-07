namespace ImpressaoComValores 
{
    public class Program 
    {
        public static void Main(string[] args) {

            // concatenação
            int idade = 21;
            string nomeDaTurma = "Sharp Coders";
            Console.WriteLine("A idade é " + idade);

            // interpolação
            int anoDeInicio = 2022;
            Console.WriteLine($"O nome da turma é {nomeDaTurma} começando em {anoDeInicio}");

        }
    }
}