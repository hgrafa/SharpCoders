using AbstratasHerancasInterfaces.Entities;
using AbstratasHerancasInterfaces.Entities.Enums;

namespace AbstratasHerancasInterfaces;

public class Program {

    public static void Main(string[] args) {

        // upcasting
        FormaGeometrica f = new Circulo(3, 1.2, Cor.CINZA);

        Console.WriteLine(f.Area());

    }

}
