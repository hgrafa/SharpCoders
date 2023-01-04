namespace ConstrutoresPrivacidades.Model {
    public class Funcionario {

        private double _salarioBruto;
        private double _imposto;

        public double SalarioBruto {
            get { return _salarioBruto; }
            set { _salarioBruto = value; }
        }

        public double Imposto {
            get { return _imposto; }
            set { _imposto = value; }
        }

        public double SalarioLiquido {
            get { return _salarioBruto - _imposto; }
        }

    }
}
