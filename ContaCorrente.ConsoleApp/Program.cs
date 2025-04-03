namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
              TransacoesEntreContas.contadorContas = 0;
            int continuar = 1;


            ContaCorrente[] Contas = new ContaCorrente[2];


            while (continuar != 4)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo ao Banco da Academia do Programador\nPara começarmos informe o numero da sua conta: ");
                int NumeroConta = Convert.ToInt32(Console.ReadLine());
                ContaCorrente usuario = new ContaCorrente(NumeroConta);

              

                Console.WriteLine("Informe qual o seu Saldo disponivel: ");
                usuario.saldoDisponivel = Convert.ToDecimal(Console.ReadLine());
                
                Console.WriteLine("Informe qual o seu Limite disponivel: ");
                usuario.limiteDisponivel = Convert.ToDecimal(Console.ReadLine());

                usuario.saldoDisponivelComOLimite = usuario.saldoDisponivel;

                if (TransacoesEntreContas.contadorContas == 1)
                {
                    Console.WriteLine("Deseja fazer uma transferencia para outra conta(1 - Sim | 2 - Nao)?");
                    int transferencia = Convert.ToInt32(Console.ReadLine());

                    if (transferencia == 1)
                        TransacoesEntreContas.Transacao(Contas);
                }
                while (continuar != 4)
                {
                    Console.Clear();
                    Console.WriteLine("informe oque deseja fazer: \n|1 - Saque\n|2 - Depósito\n|3 - Emitir Extrato\n|4 - Sair\n|5 - Se deseja transferir para outra conta digite 5 e cadastre uma nova conta");

                    continuar = Convert.ToInt32(Console.ReadLine());
                    if (continuar == 1)
                        usuario.Saque();

                    else if (continuar == 2)
                        usuario.Deposito();

                    else if (continuar == 3)
                        usuario.ExibirExtrato();

                    else
                        break;                  
                }

                
                Contas[TransacoesEntreContas.contadorContas] = usuario;

                TransacoesEntreContas.contadorContas++;
            }
        }
           
        }
    }

