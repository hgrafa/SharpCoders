namespace ByteBank1 {

    public class Program {

        static void ShowMenu() {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Detalhes de um usuário");
            Console.WriteLine("4 - Total armazenado no banco");
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

        public static void Main(string[] args) {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");

            Console.Write("Digite a quantidade de Usuários: ");
            int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

            int option;

            do {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option) {
                    case 0:
                        Console.WriteLine("Estou encerrando o programa...");
                        break;
                    case 1:
                        Console.WriteLine("Deveria estar inserindo um novo usario!");
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);
            
            

        }

    }

}