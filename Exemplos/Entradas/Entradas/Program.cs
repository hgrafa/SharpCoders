namespace Variaveis {

    public class Program {

        public static void Main(string[] args) {

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse( Console.ReadLine() );

            Console.WriteLine("---------------------------");

            double altura = 1.8;
            float nota = 8.9F;
            char sexo = 'M';
            long identificador = 4L;

            double pi = 3.14159265;

            Console.WriteLine($"Id = {identificador}");
            Console.WriteLine($"Nome do usuario: {nome}");
            Console.WriteLine($"Idade: {idade} | Altura: {altura} | sexo: {sexo}");
            Console.WriteLine($"Nota: {nota}");
            Console.WriteLine($"O valor de Pi é: {pi:F3}");
        }

    }

}

// Id = 4
// Nome do usuario: Joao da Silva
// Idade: 21 | Altura: 1.8 | sexo: M
// Nota: 8.9