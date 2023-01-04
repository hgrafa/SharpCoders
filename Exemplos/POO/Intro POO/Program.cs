using IntroPOO.Entities;

namespace IntroPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno joao = new Aluno();

            joao.Nome = "João da Silva";
            joao.Idade = 20;

            Console.WriteLine($"O nome do aluno é {joao.Nome}");

            joao.FazerAniversario();

            /* 
            List<Aluno> turma = new List<Aluno>();

            turma.Add(joao);
            turma.Add(new Aluno());
             */


        }
    }
}