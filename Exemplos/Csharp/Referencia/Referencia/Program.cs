namespace Referencia;

public class Program {

    static void Troca(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Divisao(int dividendo, int divisor, out int resultado, out int resto) {
        resto = dividendo % divisor;
        resultado = dividendo / divisor;
    }

    static void Main(string[] args) {
        int x = 2, y = 3;
        Troca(ref x, ref y);

        Console.WriteLine($"X = {x} | Y = {y}");
        Divisao(20, 4, out int resultado, out int resto);
        Console.WriteLine(resultado);
    }

}