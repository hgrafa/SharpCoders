
using Heranca.Model;

namespace Heranca;

public class Program {

    public static void Main(string[] args) {
           
        Arqueiro arq = new Arqueiro();

        // upcasting
        Personagem myPerson = new Arqueiro();

        // downcasting seguro
        if(myPerson is Arqueiro myarq) {
            Console.WriteLine("arq2 é um arqueiro");
            Console.WriteLine("Arqueiro 2 : Força = " + myarq.Arco.Forca);
        }

        // downcasting não é seguro
        ((Arqueiro)myPerson).AdquirirNovoArco(new Arco(TipoDoArco.VENENOSO));
        Console.WriteLine(((Arqueiro)myPerson).Arco.Forca);

    }

}