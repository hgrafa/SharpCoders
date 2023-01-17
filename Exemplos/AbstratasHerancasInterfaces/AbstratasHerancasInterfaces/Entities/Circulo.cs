using AbstratasHerancasInterfaces.Entities.Enums;

namespace AbstratasHerancasInterfaces.Entities; 

public class Circulo : FormaGeometrica {

    public double Raio { get; set; }

    public Circulo(double espessura, Cor cor) 
        : base(espessura, cor) {
    }

    public Circulo(double raio, double espessura, Cor cor) 
        : this(espessura, cor) {
        Raio = raio;
    }

}
