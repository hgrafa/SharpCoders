namespace Variaveis {

    public class Program {

        public static void Main(string[] args) {

            string nome = "Joao da Silva";
            int idade = 21;
            double altura = 1.8;
            float nota = 8.9f;
            char sexo = 'M';
            long identificador = 4L;

            Console.WriteLine($"Id = {identificador}");
            Console.WriteLine($"Nome do usuario: {nome}");
            Console.WriteLine($"Idade: {idade} | Altura: {altura} | sexo: {sexo}");
            Console.WriteLine($"Nota: {nota}");

        }

    }

}

// Id = 4
// Nome do usuario: Joao da Silva
// Idade: 21 | Altura: 1.8 | sexo: M
// Nota: 8.9