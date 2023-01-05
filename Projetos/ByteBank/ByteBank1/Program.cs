namespace ByteBank
{

    public class Program
    {
        // Ideia de implementação de Login

        /*static void ShowMenuLogin()
        {
            Console.WriteLine("1 - Criar novo usuário");
            Console.WriteLine("2 - Fazer Login na Conta");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Quantia total armazenada no banco");
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }*/

        static void ShowMenu()
        {
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Quantia total armazenada no banco");
            Console.WriteLine("6 - Manipular a conta");
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }
        
        static void ShowMenuManipularConta()
        {
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Saquar");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Saldo Total");
            Console.WriteLine("0 - Voltar para Menu Principal");
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
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaDeletar = cpfs.FindIndex(d => d == cpfParaDeletar);

            if(senhas[indexParaDeletar] == senhaParaPesquisar)
            {
                if (indexParaDeletar == -1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Não foi possivel deletar a conta: Conta não encontrada ou Senha errada!");
                }
                else
                {
                    // Deletando o CPF e as informações
                    cpfs.Remove(cpfParaDeletar);
                    senhas.RemoveAt(indexParaDeletar);
                    titulares.RemoveAt(indexParaDeletar);
                    saldos.RemoveAt(indexParaDeletar);
    
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Conta deletada com sucesso!");
                }
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel deletar a conta: Conta não encontrada ou Senha errada!");
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

            int indexParaApresentar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaApresentar] == senhaParaPesquisar)
            {
                if (indexParaApresentar == -1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Não foi possivel apresentar sua conta!");
                    Console.WriteLine("MOTIVO: Conta não encontrada no Sistema ou Senha errada.");
                }
                else
                {
                    ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
                }
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel apresentar sua conta!");
                Console.WriteLine("MOTIVO: Conta não encontrada no Sistema ou Senha errada.");
            }
        }

        static void ApresentarSomaTotal(List<double> saldos)
        {
            Console.WriteLine($"Total acumulado no banco: R${saldos.Sum()}");

            // saldos.Sum(); ou .Aggregate(0.0, (x, y) => x + y);
        }
        
        static void DepositoNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o CPF: ");
            string cpfParaPesquisar = Console.ReadLine();
            
            Console.WriteLine("Digite a SENHA para ver detalhes da Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaDepositar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if(senhas[indexParaDepositar] == senhaParaPesquisar)
            {
                if (indexParaDepositar == -1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Não foi possivel realizar o deposito!");
                    Console.WriteLine("MOTIVO: Conta não encontrada no Sistema ou Senha errada.");
                } 
                else 
                {
                    Console.WriteLine("Digite o valor do deposito: ");
                    double valorDeposito = saldos[indexParaDepositar] += double.Parse(Console.ReadLine());

                    Console.WriteLine("-----------------");
                    Console.WriteLine($"Deposito de: R${valorDeposito} realizado com sucesso!");
                }
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel realizar o deposito: Conta não Encontrada ou Senha errada!");
            }
        }

        static void SaqueNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para ver detalhes da Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaSaquar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaSaquar] == senhaParaPesquisar)
            {
                if (indexParaSaquar == -1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Não foi possivel realizar o Saque: Conta não Encontrada ou Senha errada!");
                }
                else
                {
                    Console.WriteLine("Digite o valor para Saquar: ");
                    double valorDeSaque = saldos[indexParaSaquar] -= double.Parse(Console.ReadLine());

                    Console.WriteLine("-----------------");
                    Console.WriteLine($"Saque de: R${valorDeSaque} realizado com sucesso!");
                }
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel realizar o Saque: Conta não Encontrada ou Senha errada!");
            }
        }

        static void TransferenciaNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para ver detalhes da Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaTransferir = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaTransferir] == senhaParaPesquisar)
            {
                if (indexParaTransferir == -1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Não foi possivel realizar a Tranferencia: Conta não Encontrada ou Senha errada!");
                }
                else
                {
                    Console.WriteLine("Informe o CPF da conta que quer transferir: ");
                    string cpfParaTranferir = Console.ReadLine();

                    int indexParaTransferirDinheiro = cpfs.FindIndex(d => d == cpfParaTranferir);

                    if (cpfs[indexParaTransferirDinheiro] == cpfParaTranferir) 
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine($"Conta do {titulares[indexParaTransferirDinheiro]} encontrada! ");

                        Console.Write($"Saldo da sua conta: R${saldos[indexParaTransferir]} | deseja transferir quanto para {titulares[indexParaTransferirDinheiro]}: ");
                        double valorDeTransferencia= double.Parse(Console.ReadLine());

                        if (valorDeTransferencia == 0)
                        {
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Transferencia indisponivel, insira um valor maior que R$ 1,00");
                        } else
                        {
                            saldos[indexParaTransferirDinheiro] += valorDeTransferencia;
                            saldos[indexParaTransferir] -= valorDeTransferencia;

                            Console.WriteLine("-----------------");
                            Console.WriteLine($"Transferencia de: R${valorDeTransferencia} realizado com sucesso para a conta {titulares[indexParaTransferirDinheiro]}!");
                        }
                        
                    }     
                }
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel realizar o Saque: Conta não Encontrada ou Senha errada!");
            }
        }

        static void SaldoTotalDaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.WriteLine("Digite a SENHA para ver detalhes da Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaPesquisar = cpfs.FindIndex(d => d == cpfParaPesquisar);

            if (senhas[indexParaPesquisar] == senhaParaPesquisar)
            {
                if (indexParaPesquisar == -1)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Não foi possivel verificar Saldo: Conta não Encontrada ou Senha errada!");
                }
                else
                {
                    double totalSaldo = saldos[indexParaPesquisar];

                    Console.WriteLine("-----------------");
                    Console.WriteLine($"Total de Saldo na sua conta: R${totalSaldo}");
                }
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Não foi possivel verificar Saldo: Conta não Encontrada ou Senha errada!");
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

            // Ideia de implementação de tela de Login

            /*int option2;

            do
            {
                ShowMenuLogin();
                option2 = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option2)
                {
                    case 0:
                        Console.WriteLine("Programa Encerrado!");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        // UsuarioRegistrado
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        ApresentarSomaTotal(saldos);
                        break;
                }

            } while (option2 != 0);*/

            int option;

            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Programa Encerrado!");
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

                Console.WriteLine("-----------------");

            } while (option != 0);



        }

    }

}