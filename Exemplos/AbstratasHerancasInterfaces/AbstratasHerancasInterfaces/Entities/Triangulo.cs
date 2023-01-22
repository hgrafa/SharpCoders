using AbstratasHerancasInterfaces.Entities.Enums;
using AbstratasHerancasInterfaces.Entities.Interfaces;

namespace AbstratasHerancasInterfaces.Entities {
    public class Triangulo : IFormaGeometrica {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo(double a, double b, double c, double espessura, Cor cor) 
            // : base(espessura, cor) 
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area() {
            // radical de heron
            double p = Perimetro() / 2;
            double prod = p*(p-A)*(p-B)*(p-C);
            return Math.Sqrt(prod);
        }

        public double Perimetro() {
            return A + B + C;
        }
    }
}
