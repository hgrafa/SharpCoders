using System.Globalization;

namespace ManipulandoArquivos;

public class Program {

    static void Main(string[] args) {
        string rootPath = @"C:\Aulas\Turmas\Sharp Coders\Exemplos\ManipulandoArquivos\ManipulandoArquivos\";

        string filePath = rootPath + "sharp_coders.txt";

        // criando um novo arquivo

        // escritor
        using (StreamWriter sw = File.AppendText(filePath)) {
            sw.WriteLine("Joao, 12, 1.6, RJ");
        }

        // leitor
        using (StreamReader sr = new StreamReader(filePath)) {
            while( !sr.EndOfStream ) {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }

}