namespace ConstrutoresPrivacidades.Model {
    public class Funcionario {

        // auto - properties
        public double SalarioBruto { get; private set; }
        public double Imposto { get; set; }

        // property
        public double SalarioLiquido {
            get { return SalarioBruto - Imposto; }
        }

    }
}
