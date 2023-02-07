using ProjetoCalculadora.Exceptions;

namespace ProjetoCalculadora;

public class Calculadora
{

    public static double Somar(double x, double y)
    {
        return x + y;
    }

    public static double Subtrair(double x, double y)
    {
        return x - y;
    }

    public static double Multiplicar(double x, double y)
    {
        return x * y;
    }

    public static double Dividir(double x, double y)
    {
        if (y == 0) 
            throw new DivisionByZeroException();

        return x / y;
    }

    static void Main(string[] args) {

    }
}