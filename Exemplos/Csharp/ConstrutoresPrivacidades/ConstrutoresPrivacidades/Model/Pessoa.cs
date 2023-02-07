namespace ConstrutoresPrivacidades.Model {
    public class Pessoa {

        // auto - properties
        public string Nome { get; set; }
        public double Altura { get; private set; }
        public int Idade { get; private set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, double altura, int idade) {
            Nome = nome;
            Altura = altura;
            Idade = idade;
        }

        public Pessoa(string nome, double altura, int idade, string telefone) 
            : this(nome, altura, idade) {
            Telefone = telefone;
        }

        // métodos
        public void FazerAniversario() {
            Idade++;
        }


    }
}
