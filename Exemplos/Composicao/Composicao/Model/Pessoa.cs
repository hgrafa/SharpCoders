namespace Composicao.Model {
    public class Pessoa {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa(string nome, int idade, Endereco endereco) {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

    }
}
