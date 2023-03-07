using System.Runtime.CompilerServices;
using static System.Console;

namespace OptionalSubjects;

//public class Exemplo {
//    static Exemplo() {
//        Console.WriteLine("Construtor estático executado.");
//    }

//    public Exemplo() {
//        Console.WriteLine("Construtor de instância executado.");
//    }
//}

/*class Contato {
    public string nome { get; set; }
    public string sobrenome { get; set; }
    public List<Telefone> Telefones { get; set; }
}

class Telefone {
    public string DDD {get; set; }
    public string Numeros { get; set; }
}*/

public static class StringExtensions {
    public static bool IsPalindrome(this string text) {
        return text.SequenceEqual( text.Reverse() );
    }

    public static bool IsLengthGreaterThanValue(this string text, int value) {
        return text.Length > value;
    }
}

public class Program {

    static void Main(string[] args) {
        string palavra = "121";
        string aula = "aula sobre extension methods em C#";
        var isPalavraPalindrome = palavra.IsPalindrome();
        WriteLine(isPalavraPalindrome);
        WriteLine(palavra.IsLengthGreaterThanValue(2));
        WriteLine(palavra.IsLengthGreaterThanValue(4));
        /*palavra.IsPalindrome*//**/
    }
}