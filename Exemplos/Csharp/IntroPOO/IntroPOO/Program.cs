using IntroPOO.Entities;
using IntroPOO.Entities.Animals;

namespace IntroPOO
{

    public class Program {

        public static void Main(string[] args) {

            Aluno joao = new Aluno();
            Aluno maria = new Aluno();
            joao.Nome = "Joao da Silva";
            joao.Idade = 20;

            Console.WriteLine($"O nome do aluno é {joao.Nome}");

            joao.FazerAniversario();

            Dog dog = new Dog();
            dog.Name = "Thor";

            Cat cat = new Cat();
            cat.Name = "Kyara";



            //List<Aluno> turma = new List<Aluno>();

            //turma.Add(joao);
            //turma.Add(new Aluno());

        }

    }

}