using Listas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAndLambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(30,10),
                new ContaCorrente(20,30),
                new ContaCorrente(10,40),
                new ContaCorrente(50,01),
                null,
                null
            };
            IOrderedEnumerable<ContaCorrente> orderedContaCorrente = 
                contas.OrderBy(conta => conta.Agencia);

            var contasNaoNulas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var item in contasNaoNulas)
            {
                Console.WriteLine($"Conta Agencia: {item.Agencia},Conta Numero: {item.Numero}");
            }

            
        }
    }
}
