using AbstratasHerancasInterfaces.Entities.Enums;

namespace AbstratasHerancasInterfaces.Entities;

public class FormaGeometrica {

    public double Espessura { get; set; }
    public Cor Cor { get; set; }

    public FormaGeometrica(Cor cor) {
        Cor = cor;
    }

    public FormaGeometrica(double espessura, Cor cor) {
        Espessura = espessura;
        Cor = cor;
    }

    public double Perimetro() {
        return -1;
    }

    public double Area() {
        return -1;
    }

}
