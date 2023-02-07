namespace IntroPOO.Entities {

    public class Aluno {

        // atributos
        public string Nome;
        public int Idade;
        public double? Nota;

        // métodos
        public void FazerAniversario() {
            Idade++;
        }

        public void FazerProva(double notaDaProva) {
            Nota = notaDaProva;
        }

        public double Somar(double a, double b) {
            return a + b;
        }

        public bool? EstaAprovado() {
            if (Nota == null)
                return null;

            if (Nota >= 7.0)
                return true;

            return false;
        }

    }

}
