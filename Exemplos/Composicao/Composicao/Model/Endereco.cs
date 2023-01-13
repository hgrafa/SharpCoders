namespace Composicao.Model {
    public class Endereco {

        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }

        public Endereco(string pais, string estado, string bairro, string rua, string numero, string cEP) {
            Pais = pais;
            Estado = estado;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            CEP = cEP;
        }
    }
}