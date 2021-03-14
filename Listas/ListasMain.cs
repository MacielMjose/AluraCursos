using Listas.Comparadores;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Listas
{
    class ListasMain
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            List<string> nomes = new List<string>()
            {
                "josé",
                "ana",
                "joaquim",
                "jordana",
                "jorge"
            };

            idades.Add(10);
            idades.Add(30);
            idades.Add(20);
            idades.Sort();
            nomes.Sort();

            //foreach (var idade in idades)
            //{
            //    Console.WriteLine(idade);
            //}
            //foreach (var nome in nomes)   
            //{
            //    Console.WriteLine(nome);
            //}

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(0221,0334523),
                new ContaCorrente(0222,0321234),
                new ContaCorrente(1,0312343)

            };

            //contas.Sort(); ->chama a implementação dada em Icomparable
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine($"{conta.Agencia},{conta.Numero},{conta}");
            }
            
        }
    }
}
