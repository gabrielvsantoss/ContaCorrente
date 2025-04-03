


namespace ContaCorrente.ConsoleApp
{
    public static class TransacoesEntreContas
    {
       public static int contadorContas = 0;
  
        
        public static void Transacao(ContaCorrente[] Contas)
        {
            Console.WriteLine("Quanto deseja transferir para a outra conta?");
            int valorTemporario = Convert.ToInt32(Console.ReadLine());

            Contas[0].saldoDisponivel = Contas[1].saldoDisponivel - valorTemporario;
            Console.WriteLine($"Saldo disponivel depois da transferencia na Conta 01: {Contas[0].saldoDisponivel}\nDigite ENTER para visualizar a outra conta");
            Console.ReadLine();

            Contas[1].saldoDisponivel = Contas[1].saldoDisponivel + valorTemporario;
            Console.WriteLine($"Saldo disponivel depois do depósito na Conta 02: {Contas[1].saldoDisponivel}\nDigite ENTER para sair");
            Console.ReadLine();

        }
    }
}
