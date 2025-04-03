

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {

        public decimal saldoDisponivel;
        public decimal quantiaDepositada;
        public decimal saldoDisponivelComOLimite;
        public decimal limiteDisponivel;
        public decimal valorGastoTotal = 0;
        public int numeroConta;
        public string[] Extrato = new string[100];
        public int transacoes = 0;

       public ContaCorrente(int NumeroConta)
       {
            numeroConta = NumeroConta;
       }

        public void Saque() 
        {
            Console.WriteLine("Quanto deseja Sacar do seu saldo?");
            decimal quantiaResgatada = Convert.ToDecimal(Console.ReadLine());

            valorGastoTotal += quantiaResgatada;
            saldoDisponivel += quantiaDepositada;

            if(valorGastoTotal >= saldoDisponivel)
            {
                Console.WriteLine("Voce ja gastou todo seu saldo mas ainda possui um limite de crédito deseja gasta-lo? \n(1 - Sim | 2 - não)");
                int resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    saldoDisponivelComOLimite = (saldoDisponivelComOLimite + limiteDisponivel) - quantiaResgatada;
                    Console.WriteLine("Saque efetuado com sucesso clique ENTER para realizar uma nova operaçãp");
                    Console.ReadLine();
                    Extrato[transacoes] = $"Saque: {quantiaResgatada}, Valor Final:{saldoDisponivelComOLimite}";
                    transacoes++;
                }


            }

            else if (valorGastoTotal < saldoDisponivel)
            {
                saldoDisponivelComOLimite = (saldoDisponivelComOLimite + limiteDisponivel) - quantiaResgatada;
                Console.WriteLine("Saque efetuado com sucesso clique ENTER para realizar uma nova operaçãp");
                Console.ReadLine();
                Extrato[transacoes] = $"Saque: {quantiaResgatada}, Valor Final:{saldoDisponivelComOLimite}";
                transacoes++;

            }



       

           
        }

        public void Deposito()
        {
            quantiaDepositada = 0;
            Console.WriteLine("Quanto deseja depositar no seu saldo?");
            quantiaDepositada = Convert.ToDecimal(Console.ReadLine());

            
            Console.WriteLine("Depósito efetuado com sucesso digite ENTER para realizar uma nova operaçãp");
            Console.ReadLine();

            saldoDisponivelComOLimite = (saldoDisponivel + limiteDisponivel) - quantiaDepositada;
            Extrato[transacoes] = $"Depósito: {quantiaDepositada}, Valor Final:{saldoDisponivelComOLimite}";
            transacoes++;
        }
        
        public void ExibirExtrato()
        {
            for (int i = 0; i < Extrato.Length; i++)
            {
                if (Extrato[i] != null)
                Console.WriteLine(Extrato[i]);
            }

            Console.ReadLine();
        }
    }
}
