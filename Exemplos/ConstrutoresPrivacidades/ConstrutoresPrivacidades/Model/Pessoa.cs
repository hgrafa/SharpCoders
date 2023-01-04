namespace ConstrutoresPrivacidades.Model {
    public class Pessoa {

        // atributos
        private string _nome;
        private double _altura;
        private int _idade;
        private string _telefone;

        // construtores
        public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada) {
            _nome = nomeEntrada;
            _altura = alturaEntrada;
            _idade = idadeEntrada;
        }

        public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada, string telefoneEntrada) {
            _nome = nomeEntrada;
            _altura = alturaEntrada;
            _idade = idadeEntrada;
            _telefone = telefoneEntrada;
        }

        // getters and setters tradicionais

        //public string GetNome() {
        //    return Nome;
        //}

        //public void SetNome(string value) {
        //    _nome = value;
        //}
        
        // properties - 

        public string Nome {
            get { return _nome; }
            set { _nome = value;  }
        }

        public double Altura {
            get { return _altura; }
            set { 
                if(value > 0) 
                    _altura = value;
            }
        }
        
        // métodos
        public void FazerAniversario() {
            _idade++;
        }


    }
}
