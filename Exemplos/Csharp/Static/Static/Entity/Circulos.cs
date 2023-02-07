namespace Static.Entity {
    public class Circulos {

        public static double CalcularPerimetro (double raio) {
            return 2 * Circulo.PI * raio;
        }

        public static double CalcularArea (double raio) {
            return Circulo.PI * raio * raio;
        }

    }
}
