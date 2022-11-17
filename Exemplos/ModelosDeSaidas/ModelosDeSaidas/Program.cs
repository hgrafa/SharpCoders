namespace ModelosDeSaidas {

    public class Program {

        public static void Main(string[] args) {

            string nomeDoUsuario = "João";
            string codigoDoUsuario = "123ABC";
            string textoParaSerEnviado = $"O nome do usuário deste projeto é {nomeDoUsuario}";

            Console.WriteLine(textoParaSerEnviado);

            Console.WriteLine("O nome do usuario deste projeto é {0} {1} {2}", nomeDoUsuario, codigoDoUsuario, codigoDoUsuario);

            Console.Write("Ele não");
            Console.Write("Pula linha");

            Console.Write("Fazendo\n");
            Console.Write("Meu código\n");
            Console.Write("Pular Linha\n");

        }

    }

}

// O nome do usuário deste projeto é Joao
// O nome do usuario deste projeto é Joao 123ABC 123ABC

// Ele naoPula linha

// Ele naoPula linhaFazendo
// Meu código
// Pular Linha