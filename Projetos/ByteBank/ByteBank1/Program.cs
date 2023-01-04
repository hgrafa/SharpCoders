namespace ByteBank
{

    public class Program
    {

        static void ShowMenu()
        {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Quantia armazenada no banco");
            Console.WriteLine("6 - Manipular a conta"); // novo menu nesta opção para: deposito, saque, e transferência
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o CPF: ");
            cpfs.Add(Console.ReadLine());
            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.WriteLine("Insira sua senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
            Console.WriteLine("Usuário cadastrado!");
        }

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o CPF: ");
            string cpfParaDeletar = Console.ReadLine();
            Console.WriteLine("Digite a SENHA para deletar a Conta: ");
            string senhaParaDeletar = Console.ReadLine();

            // Aqui no FindIndex usamos um predicado falando assim: d tal que d e igual ao cpf para deletar? se sim retorne true se não retorne false(-1)
            int indexParaDeletar = senhas.FindIndex(d => d == senhaParaDeletar);


            // Ideia implemtação de senha:

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel deletar a conta!");
                Console.WriteLine("MOTIVO: Conta não encontrada ou senha errada");
            }
            else
            {
                // Deletando o CPF e as informações
                cpfs.Remove(cpfParaDeletar);
                senhas.Remove(senhaParaDeletar);
                titulares.RemoveAt(indexParaDeletar);
                saldos.RemoveAt(indexParaDeletar);

                Console.WriteLine("-----------------");
                Console.WriteLine("Conta deletada com sucesso!");
            }
        }

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o CPF: ");
            string cpfParaPesquisar = Console.ReadLine();
            Console.WriteLine("Digite a SENHA para ver detalhes da Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaApresentar = senhas.FindIndex(d => d == senhaParaPesquisar);

            if (indexParaApresentar == -1)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel apresentar conta!");
                Console.WriteLine("MOTIVO: Conta não encontrada no Sistema.");
            }

            ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
        }

        static void ApresentarSoma(List<double> saldos)
        {
            Console.WriteLine($"Total acumulado no banco: R${saldos.Sum()}");

            // saldos.Sum(); ou .Aggregate(0.0, (x, y) => x + y);
        }
        static void ApresentaConta(int i, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}");
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");


            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;

            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Progrma Encerrado!");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        DeletarUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        ApresentarUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 5:
                        ApresentarSoma(saldos);
                        break;
                }

                Console.WriteLine("-----------------");

            } while (option != 0);



        }

    }

}