using AbstratasHerancasInterfaces.Entities.Enums;
using AbstratasHerancasInterfaces.Entities.Interfaces;

namespace AbstratasHerancasInterfaces.Entities; 

public class Circulo : IFormaGeometrica {

    public static readonly double PI = 3.14159265;
    public double Raio { get; set; }

    // resolver a questão da classe
    // public Circulo(double espessura, Cor cor) 
       // : base(espessura, cor) {
    // }

    public Circulo(double raio, double espessura, Cor cor) 
       // : this(espessura, cor)
    {
        Raio = raio;
    }

    public double Perimetro() {
        return 2 * PI * Raio;
    }

    // sobrepondo regras da classe FormaGeometrica
    public double Area() {
        return PI * Raio * Raio;
    }

}
