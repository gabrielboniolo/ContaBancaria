using System.Globalization;
namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancaria conta;

            Console.Write("Entre o número da conta: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
           
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta_Bancaria(cod, titular, saldo);
            }
            else
            {
                conta = new Conta_Bancaria(cod, titular);
            }
            

            Console.WriteLine($"Dados da conta: {conta}");

            Console.WriteLine();
            Console.Write("Entre um valor para o depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine($"Dados da conta atualizados: {conta}");

            Console.WriteLine();
            Console.Write("Entre um valor para o saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine($"Dados da conta atualizados: {conta}");

        }
    }
}