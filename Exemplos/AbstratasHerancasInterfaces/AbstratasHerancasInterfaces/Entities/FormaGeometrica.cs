using AbstratasHerancasInterfaces.Entities.Enums;

namespace AbstratasHerancasInterfaces.Entities;

public abstract class FormaGeometrica {

    public double Espessura { get; set; }
    public Cor Cor { get; set; }

    public FormaGeometrica(Cor cor) {
        Cor = cor;
    }

    public FormaGeometrica(double espessura, Cor cor) {
        Espessura = espessura;
        Cor = cor;
    }

    public virtual double Perimetro() {
        return -1;
    }

    public virtual double Area() {
        return -1;
    }

}
