using _06_ByteBank;
using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("031.229.220-10","josé maciel");
            ContaCorrente conta = new ContaCorrente(0265,06351654,cliente);
            
            Cliente jordana = new Cliente("002.113.323-10", "jordaninha");
            ContaCorrente conta1 = new ContaCorrente(0245, 12341223, jordana);

            Console.WriteLine(conta.Titular.Cpf);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine("is executing?");
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            
        }
    }
}
