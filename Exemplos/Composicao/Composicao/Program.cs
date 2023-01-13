using Composicao.Model;

namespace Composicao {

    public class Program {

        static void Main(string[] args) {

            Pessoa lucas = new Pessoa("Lucas da Silva", 24,
                new Endereco("Br", "RJ", "Barra", "Rua Helios Sellinger", "100", "123"));


            Console.WriteLine(lucas.Endereco.Numero);
        }
        
    }

}