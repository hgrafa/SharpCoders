using ConstrutoresPrivacidades.Model;

namespace ConstrutoresPrivacidades {

    public class Program {

        public static void Main(string[] args) {

            Pessoa marcos = new Pessoa("Marcos Castro", 1.90, 18);

            marcos.Altura = -2;

            Pessoa julia = new Pessoa("Julia Silva", 1.70, 20, "99999999");

            Console.WriteLine(marcos.Altura);

        }

    }

}