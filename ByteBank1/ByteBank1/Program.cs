using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace ByteBank1
{

    public class Program
    {
        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--> Selecione uma opção: ");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Para cadastrar novo usuário");
            Console.WriteLine("2 - Para deletar um usuário");
            Console.WriteLine("3 - Para listar todas os usuários cadastrados");
            Console.WriteLine("4 - Para obter detalhes de um usuário");
            Console.WriteLine("5 - Para manipular sua conta");// Submenu: pede o CPF e a senha correta => acesso a um novo menu => Depositar, sacar, transferir e sair para o menu inicial.
            Console.WriteLine("0 - Para sair do programa");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite a opção desejada: ");
            Console.ResetColor();
        }

        static void ShowMenu2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--> Selecione uma opção: ");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Para depositar");
            Console.WriteLine("2 - Para sacar");
            Console.WriteLine("3 - Para transferir");
            Console.WriteLine("4 - Para fazer logout e voltar ao menu inicial");

            Console.ResetColor();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite a opção desejada: ");
            Console.ResetColor();
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, List<string> telefone, List<string> endereço)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CADASTRANDO UM NOVO USUÁRIO");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            saldos.Add(0);
            Console.Write("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Digite o telefone: ");
            telefone.Add(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            endereço.Add(Console.ReadLine());
            Console.Write("Insira uma senha: ");
            senhas.Add(Console.ReadLine());
            Console.ResetColor();
            saldos.Add(0);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Usuário cadastrado com sucesso! ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
        }

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, List<string> telefone, List<string> endereço)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("DELETANDO UM USUÁRIO");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o CPF do usuário que você deseja deletar: ");
            string cpfDigitado = Console.ReadLine();
            int posiçaoCPFencontrado = -1;

            for (int k = 0; k < cpfs.Count; k++)
            {
                if (cpfDigitado == cpfs[k])
                {
                    posiçaoCPFencontrado = k;
                }

                if (posiçaoCPFencontrado < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Usuario não cadastrado.");
                    Console.ResetColor();
                    return;
                }

                if (cpfDigitado == cpfs[posiçaoCPFencontrado])
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Tem certeza que deseja deletar o titular {titulares[posiçaoCPFencontrado]} ?");
                    string resposta = Console.ReadLine();

                    if (resposta == "Sim")
                    {
                        cpfs.RemoveAt(posiçaoCPFencontrado);
                        Console.WriteLine("Usuário deletado com sucesso!");
                    }

                    else
                    {
                        return;

                    }
                }
            }
        }

        static void ListarTodasAsContas(List<string> titulares, List<string> cpfs)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("LISTA DOS USUÁRIOS CADASTRADOS: ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < titulares.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Titular: {titulares[i]} | CPF: {cpfs[i]}");
                Console.ResetColor();
            }

        }
        static void DetalhesUsuario(List<string> cpfs, List<string> titulares, List<double> saldos, List<string> telefone, List<string> endereço)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CONSULTA DE USUÁRIO");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o cpf do titular: ");
            Console.ResetColor();
            string cpfDigitado2 = Console.ReadLine();
            int posiçaoCPFencontrado2 = -1;
            for (int j = 0; j < cpfs.Count; j++)
            {
                if (cpfDigitado2 == cpfs[j])
                {
                    posiçaoCPFencontrado2 = j;
                }
            }
            if (posiçaoCPFencontrado2 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuario não cadastrado.");
                Console.ResetColor();
                return;
            }

            if (cpfDigitado2 == cpfs[posiçaoCPFencontrado2])
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("DETALHES DO USUÁRIO PROCURADO:");
                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Titular: {titulares[posiçaoCPFencontrado2]}");
                Console.WriteLine($"CPF: {cpfs[posiçaoCPFencontrado2]}");
                Console.WriteLine($"Telefone: {telefone[posiçaoCPFencontrado2]}");
                Console.WriteLine($"Endereço: {endereço[posiçaoCPFencontrado2]}");
                Console.WriteLine($"Saldo: R$ {saldos[posiçaoCPFencontrado2]:f2}");
                Console.ResetColor();
            }

        }
        static void ManipularConta(int posiçaoCPFencontrado, List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ÁREA DE LOGUIN ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite seu CPF: ");
            string cpfDigitado = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string senhaDigitada = Console.ReadLine();
            Console.ResetColor();
            posiçaoCPFencontrado = -1;

            for (int i = 0; i < cpfs.Count; i++)
            {
                if (cpfDigitado == cpfs[i])
                {
                    posiçaoCPFencontrado = i;
                }
            }

            if (posiçaoCPFencontrado < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Senha e/ou usuário incorreto, voltando pro menu anterior...");
                Console.ResetColor();
                return;
            }

            if (senhaDigitada == senhas[posiçaoCPFencontrado])
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Olá, {titulares[posiçaoCPFencontrado]}! Que operação você deseja fazer?");
                Console.WriteLine($"Conta corrente: R$ {saldos[posiçaoCPFencontrado]:f2}");

                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
                int opcaoDigitada = 0;
                while (opcaoDigitada != 5)
                {
                    ShowMenu2();
                    opcaoDigitada = int.Parse(Console.ReadLine());

                    switch (opcaoDigitada)
                    {
                        case 1:
                            Depositar(posiçaoCPFencontrado, saldos);
                            break;

                        case 2:
                            Sacar(posiçaoCPFencontrado, saldos);
                            break;

                        case 3:
                            Transferir(posiçaoCPFencontrado, saldos, cpfs);
                            break;

                        case 4:
                            Console.Clear();
                            return;
                            
                    }

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Senha e/ou usuário incorreto, voltando pro menu anterior...");
                Console.ResetColor();
            }

        }
        static void Depositar(int posiçaoCPFencontrado, List<double> Saldos)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ÁREA DE DEPÓSITOS ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Qual valor você deseja depositar?");
            Console.ResetColor();
            double valorDepositado = double.Parse(Console.ReadLine());
            Saldos[posiçaoCPFencontrado] += valorDepositado;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Depósito feito com sucesso!");
            Console.WriteLine($"Seu novo saldo é: R${Saldos[posiçaoCPFencontrado]:f2}");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
        }
        static void Sacar(int posiçaoCPFencontrado, List<double> Saldos)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ÁREA DE SAQUES ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Qual valor você deseja sacar?");
            Console.ResetColor();
            double valorSacado = double.Parse(Console.ReadLine());
            Saldos[posiçaoCPFencontrado] -= valorSacado;
            Console.Clear();

            if (valorSacado <= Saldos[posiçaoCPFencontrado])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Saque feito com sucesso!");
                Console.WriteLine($"Seu novo saldo é: R${Saldos[posiçaoCPFencontrado]:f2}");
                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Valor indisponível");
                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
            }
        }

        static void Transferir(int posiçaoCPFencontrado, List<double> Saldos, List<string> cpfs)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ÁREA DE TRANSFERÊNCIAS ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o CPF do titular a quem será destinada a transferência:");
            string cpfTitularDigitado = Console.ReadLine();            
            int posiçaoCPFTitular = -1;
            
            for (int i = 0; i < cpfs.Count; i++)
            {
                if (cpfTitularDigitado == cpfs[i])
                {
                    posiçaoCPFTitular = i;
                }
            }

            if (posiçaoCPFTitular < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuário não encontrado.");
                Console.ResetColor();
                return;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Digite o valor que deseja transferir:");
                double valorTransferido = double.Parse(Console.ReadLine());
                Saldos[posiçaoCPFTitular] += valorTransferido;
                Saldos[posiçaoCPFencontrado] -= valorTransferido;
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Transferência feita com sucesso!");
                Console.WriteLine($"Seu novo saldo é: R${Saldos[posiçaoCPFencontrado]:f2}");
                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
            }


        }
            public static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Bem-vindo(a) ao ByteBank!");
                Console.WriteLine("---------------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Como podemos te ajudar hoje? ");
                Console.ResetColor();
                Console.WriteLine(" ");

                // Menu Principal
                List<string> cpfs = new List<string>();
                List<string> titulares = new List<string>();
                List<string> senhas = new List<string>();
                List<string> telefone = new List<string>();
                List<string> endereço = new List<string>();

                // Menu Secundário
                List<double> depositos = new List<double>();
                List<double> saques = new List<double>();
                List<double> transferencias = new List<double>();
                List<double> saldos = new List<double>();
                int posiçaoCPFencontrado = -1;

                int option;

                do {

                    ShowMenu();

                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Estou encerrando o programa...");
                            Console.ResetColor();
                            break;
                        case 1:
                            RegistrarNovoUsuario(cpfs, titulares, senhas, saldos, telefone, endereço);
                            break;
                        case 2:
                            DeletarUsuario(cpfs, titulares, senhas, saldos, telefone, endereço);
                            break;
                        case 3:
                            ListarTodasAsContas(titulares, cpfs);
                            break;
                        case 4:
                            DetalhesUsuario(cpfs, titulares, saldos, telefone, endereço);
                            break;
                        case 5:
                            ManipularConta(posiçaoCPFencontrado, cpfs, titulares, senhas, saldos);
                            break;

                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("---------------------------------------");
                    Console.ResetColor();
                } while (option != 0);


            }

        }
    }
       




