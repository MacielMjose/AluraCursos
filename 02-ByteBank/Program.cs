using _05_ByteBank;
using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela Almeida Dos Santos";
            gabriela.profissao = "Engenheira";
            gabriela.cpf = "033.456.123-10";

            ContaCorrente contaGabriela = new ContaCorrente(gabriela);
            contaGabriela.numero = 817945632;
            contaGabriela.agencia = 1026;
            contaGabriela.Depositar(300);

            Console.WriteLine(contaGabriela.titular.nome);
            Console.WriteLine(contaGabriela.titular.cpf);
            Console.WriteLine(contaGabriela.titular.profissao);
            Console.WriteLine(contaGabriela.titular.profissao);
            Console.WriteLine(typeof(ContaCorrente));
            Console.WriteLine(typeof(Cliente));

        }
    }
} 
