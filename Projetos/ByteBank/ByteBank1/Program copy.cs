using System.Reflection.Metadata.Ecma335;

namespace ByteBank1 {

    public class Program {

        static void ShowMenu() {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Quantia armazenada no banco");
            Console.WriteLine("6 - Manipular a conta"); // novo menu nesta opção para: deposito, saque, e transferência
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos){
            Console.WriteLine("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.WriteLine("Insira sua senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
        }

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos) {
            for(int i = 0; i < cpfs.Count; i++) {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldo[i]:F2}");
            }
        }

        stactic void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos) {
            Console.WriteLine("Digite o cpf: ");
            string cpfParaDeletar = Console.ReadLine();
            // Console.WriteLine("Digite a senha para o CPF deletar: ");
            // string senhaParaDeletar = Console.ReadLine();

            // Aqui no FindIndex usamos um predicado falando assim: d tal que d e igual ao cpf para deletar? se sim retorne true se não retorne false(-1)
            int indexParaDeletar = cpfs.FindIndex(d => d == cpfParaDeletar);
            // int senhaParaDeletar = senhas.FindIndex(d => d == senhaParaDeletar);


            if(indexParaDeletar == -1) {
                Console.WriteLine("Não foi possivel deletar este CPF");
                Console.WriteLine("MOTIVO: Conta não encontrada");
            } else {
                // Deletando o CPF e as informações
                cpfs.Remove(cpfParaDeletar);
                titulares.RemoveAt(indexParaDeletar);
                senhas.RemoveAt(senhaParaDeletar);
                saldos.RemoveAt(indexParaDeletar);

                Console.WriteLine("Conta deletada com sucesso!");
            }

            // Ideia implemtação de senha:

            // if(senhaParaDeletar == -1) {
            //     Console.WriteLine("Não foi possivel deletar");
            //     Console.WriteLine("MOTIVO: Conta não encontrada ou senha errada");
            // } else {
            //     // Deletando o CPF e as informações
            //     cpfs.Remove(cpfParaDeletar);
            //     titulares.RemoveAt(indexParaDeletar);
            //     senhas.RemoveAt(senhaParaDeletar);
            //     saldos.RemoveAt(indexParaDeletar)

            //     Console.WriteLine("Conta deletada com sucesso!")
            // }
        }

        public static void Main(string[] args) {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");

            Console.WriteLine("Digite a quantidade de Usuários: ");
            int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

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
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        Console.WriteLine("Usuário cadastrado!");
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);
            
            

        }

    }

}