namespace ByteBank
{

    public class Program
    {
        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 - Inserir um novo usuário");
            Console.WriteLine("2 - Deletar Conta");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Quantia total armazenada no banco");
            Console.WriteLine("6 - Manipular a conta");
            Console.WriteLine("0 - Para sair do programa");
            Console.ResetColor();

            Console.Write("Digite a opção desejada: ");
        }
        
        static void ShowMenuManipularConta()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Saquar");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Saldo Total");
            Console.WriteLine("0 - Voltar para Menu Principal");
            Console.ResetColor();

            Console.Write("Digite a opção desejada: ");
        }

        static void WriteTextFormatedAndColor(string txt, string color)
        {
            if (color == "Red" || color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("");
                Console.Write(String.Concat(Enumerable.Repeat("-", 15)));

                Console.Write(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 15)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Green" || color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                System.Console.WriteLine(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Background" || color == "background")
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.Write(String.Concat(Enumerable.Repeat("-", 15)));

                System.Console.Write(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 15)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Blue" || color == "blue")
            {

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                System.Console.WriteLine(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                Console.WriteLine("");

                Console.ResetColor();
            }
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o seu CPF: ");
            cpfs.Add(Console.ReadLine());

            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());

            Console.WriteLine("Insira sua senha: ");
            senhas.Add(Console.ReadLine());

            saldos.Add(0);

            WriteTextFormatedAndColor("Usuário cadastrado com sucesso!", "Green");
        }

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaDeletar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para Deletar a conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaDeletar = cpfs.FindIndex(d => d == cpfParaDeletar);

            if(senhas[indexParaDeletar] == senhaParaPesquisar)
            {
                if (indexParaDeletar == -1)
                {
                    WriteTextFormatedAndColor("Não foi possivel deletar a conta: Conta não encontrada ou Senha Errada!", "Red");
                }
                else
                {
                    // Deletando o CPF e as informações
                    cpfs.Remove(cpfParaDeletar);
                    senhas.RemoveAt(indexParaDeletar);
                    titulares.RemoveAt(indexParaDeletar);
                    saldos.RemoveAt(indexParaDeletar);
    
                    WriteTextFormatedAndColor($"Conta do {titulares[indexParaDeletar]} deletada com sucesso!", "Green");
                }
            }
            else
            {
                WriteTextFormatedAndColor("Não foi possivel deletar a conta: Conta não encontrada ou Senha Errada!", "Red");
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
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();
            
            Console.WriteLine("Digite a SENHA para ver detalhes da conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaApresentar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaApresentar] == senhaParaPesquisar)
            {
                if (indexParaApresentar == -1)
                {
                    WriteTextFormatedAndColor("Erro: Conta não encontrada ou Senha Errada!", "Red");
                }
                else
                {
                    ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
                }
            }
            else
            {
                WriteTextFormatedAndColor("Erro: Conta não encontrada ou Senha Errada!", "Red");
            }
        }

        static void ApresentarSomaTotal(List<double> saldos)
        {
            WriteTextFormatedAndColor($"Total acumulado no Banco: R${saldos.Sum()} ", "background");

            // saldos.Sum(); ou .Aggregate(0.0, (x, y) => x + y);
        }
        
        static void DepositoNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();
            
            Console.WriteLine("Digite a SENHA para Depositar na conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaDepositar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if(senhas[indexParaDepositar] == senhaParaPesquisar)
            {
                if (indexParaDepositar == -1)
                {
                    WriteTextFormatedAndColor("Não foi possivel realizar o Deposito: Conta não Encontrada ou Senha Errada!", "Red");
                } 
                else 
                {
                    Console.WriteLine("Digite o valor do deposito: ");
                    double valorDeposito = saldos[indexParaDepositar] += double.Parse(Console.ReadLine());

                    WriteTextFormatedAndColor($"Deposito de: R${valorDeposito} realizado com sucesso!", "Green");
                }
            }
            else
            {
                WriteTextFormatedAndColor("Não foi possivel realizar o Deposito: Conta não Encontrada ou Senha Errada!", "Red");
            }
        }

        static void SaqueNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para continuar: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaSaquar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaSaquar] == senhaParaPesquisar)
            {
                if (indexParaSaquar == -1)
                {
                    WriteTextFormatedAndColor("Não foi possivel realizar o Saque: Conta não Encontrada ou Senha Errada!", "Red");
                }
                else
                {
                    Console.WriteLine("Digite o valor para Saquar: ");
                    double valorDeSaque = saldos[indexParaSaquar] -= double.Parse(Console.ReadLine());

                    Console.WriteLine("-----------------");
                    Console.WriteLine($"Saque de: R${valorDeSaque} realizado com sucesso!");
                    Console.WriteLine($"Saldo Atual da conta: {saldos[indexParaSaquar]}");
                }
            }
            else
            {
                WriteTextFormatedAndColor("Não foi possivel realizar o Saque: Conta não Encontrada ou Senha Errada!", "Red");
            }
        }

        static void TransferenciaNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para continuar: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaTransferir = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaTransferir] == senhaParaPesquisar)
            {
                if (indexParaTransferir == -1)
                {
                    WriteTextFormatedAndColor("Não foi possivel realizar a Transferência: Conta não Encontrada ou Senha Errada!", "Red");
                }
                else
                {
                    Console.WriteLine("Informe o CPF da conta de Transferência: ");
                    string cpfParaTranferir = Console.ReadLine();

                    int indexParaTransferirDinheiro = cpfs.FindIndex(d => d == cpfParaTranferir);

                    if (cpfs[indexParaTransferirDinheiro] == cpfParaTranferir) 
                    {
                        WriteTextFormatedAndColor($"Conta do {titulares[indexParaTransferirDinheiro]} encontrada! ", "Green");

                        WriteTextFormatedAndColor($"Saldo da sua conta: R${saldos[indexParaTransferir]} | deseja transferir quanto para {titulares[indexParaTransferirDinheiro]}: ", "Green");
                        double valorDeTransferencia= double.Parse(Console.ReadLine());

                        if (valorDeTransferencia < 1)
                        {
                            WriteTextFormatedAndColor("Transferência indisponivel, insira um valor maior que R$ 1,00", "Red");
                        } else
                        {
                            saldos[indexParaTransferirDinheiro] += valorDeTransferencia;
                            saldos[indexParaTransferir] -= valorDeTransferencia;

                            WriteTextFormatedAndColor($"Transferência de: R${valorDeTransferencia} realizado com sucesso para a conta {titulares[indexParaTransferirDinheiro]}!", "Green");
                        }
                        
                    }     
                }
            }
            else
            {
                WriteTextFormatedAndColor("Não foi possivel realizar a Transferência: Conta não Encontrada ou Senha Errada!", "Red");
            }
        }

        static void SaldoTotalDaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para ver Saldo da Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaPesquisar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaPesquisar] == senhaParaPesquisar)
            {
                if (indexParaPesquisar == -1)
                {
                    Console.WriteLine("");
                    Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                    Console.WriteLine("Não foi possivel verificar Saldo: Conta não Encontrada ou Senha Errada!");
                    Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                    Console.WriteLine("");
                }
                else
                {
                    double totalSaldo = saldos[indexParaPesquisar];

                    Console.WriteLine("");
                    Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                    Console.WriteLine($"Total de Saldo na sua conta: R${totalSaldo}");
                    Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                Console.WriteLine("Não foi possivel verificar Saldo: Conta não Encontrada ou Senha Errada!");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
            }
        }

        static void ManipularConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            int option;
            do
                {
                    ShowMenuManipularConta();
                    option = int.Parse(Console.ReadLine());
                    
                    switch (option)
                        {
                            case 0:
                                Console.WriteLine("Voltando ao Menu Principal!");
                                break;
                            case 1:
                                DepositoNaConta(cpfs, titulares, senhas, saldos);
                                break;
                            case 2:
                                SaqueNaConta(cpfs, titulares, senhas, saldos);
                                break;
                            case 3:
                                TransferenciaNaConta(cpfs, titulares, senhas, saldos);
                                break;
                            case 4:
                                SaldoTotalDaConta(cpfs, titulares, senhas, saldos);
                                break;
                    }
        
                    Console.WriteLine("-----------------");
        
            } while (option != 0);
        }
    
        static void ApresentaConta(int i, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            WriteTextFormatedAndColor($"CPF = {cpfs[i]} | TITULAR = {titulares[i]} | SALDO = R${saldos[i]:F2}", "green");
        }

        public static void Main(string[] args)
        {
            WriteTextFormatedAndColor("Bem Vindo ao Byte Bank o mais rápido e seguro!", "background");

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;

            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        WriteTextFormatedAndColor("Programa Encerrado!", "Red");
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
                        ApresentarSomaTotal(saldos);
                        break;
                    case 6:
                        ManipularConta(cpfs, titulares, senhas, saldos);
                        break;
                }

            } while (option != 0);



        }

    }

}