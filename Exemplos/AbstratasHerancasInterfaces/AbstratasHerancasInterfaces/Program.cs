using AbstratasHerancasInterfaces.Entities;
using AbstratasHerancasInterfaces.Entities.Enums;

namespace AbstratasHerancasInterfaces;

public class Program {

    public static void Main(string[] args) {

        // upcasting se mantém com classes abstratas
        FormaGeometrica c = new Circulo(3, 1.2, Cor.CINZA);
        FormaGeometrica t = new Triangulo(3, 4, 5, 1.5, Cor.AZUL);

        Console.WriteLine(c.Area());
        Console.WriteLine(t.Area());

    }

}
