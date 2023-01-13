using Static.Entity.Enums;

namespace Static.Entity {
    public class Circulo {

        // atributos
        public static readonly double PI = 3.14159265;
        public double Espessura { get; set; }
        public double Raio { get; set; }
        public Color Cor { get; set; }

        // properties
        public double Perimetro {
            get { return 2 * PI * Raio; }
        }

        public double Area {
            get { return PI * Raio * Raio; }
        }

        // construtores
        public Circulo(double raio) {
            Raio = raio;
        }

        public Circulo(double espessura, double raio, Color cor) 
            : this(raio) {
            Espessura = espessura;
            Cor = cor;
        }

        public override string ToString() {
            return $"Circulo : {{\n" +
                $"\tEspessura: {Espessura},\n" +
                $"\tRaio: {Raio},\n" +
                $"\tCor: {Cor},\n" +
                $"\tArea: {Area},\n" +
                $"\tPerimetro: {Perimetro}" +
                $"}}";
        }

        public override bool Equals(object? obj) {
            return obj is Circulo other &&
                   Espessura == other.Espessura &&
                   Raio == other.Raio &&
                   Cor == other.Cor;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Espessura, Raio, Cor, Perimetro, Area);
        }
    }
}
