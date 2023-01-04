namespace ConstrutoresPrivacidades.Model {
    public class Pessoa {

        // atributos
        private string Nome;
        private double Altura;
        private int _idade;
        private string Telefone;

        // construtores
        public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada) {
            Nome = nomeEntrada;
            Altura = alturaEntrada;
            _idade = idadeEntrada;
        }

        public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada, string telefoneEntrada) {
            Nome = nomeEntrada;
            Altura = alturaEntrada;
            _idade = idadeEntrada;
            Telefone = telefoneEntrada;
        }

        public string GetNome() {
            return Nome;
        }

        public void SetNome(string nomeEntrada) {
            Nome = nomeEntrada;
        }

        public int GetIdade() {
            return _idade;
        }

        public void SetIdade(int idadeEntrada) {
            _idade = idadeEntrada;
        }

        // métodos
        public void FazerAniversario() {
            _idade++;
        }


    }
}
