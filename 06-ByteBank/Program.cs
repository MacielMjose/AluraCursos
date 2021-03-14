using _06_ByteBank.Assets;
using System;
using System.IO;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Cath no método main");
            }
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                //Idisposable to be implemented
                leitor.LerProximaLinha();
            }

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas1.txt");
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
            //}
            //finally //finally é executado sempre
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                Cliente cliente1 = new Cliente("031.229.220.10", "josé");
                Cliente cliente2 = new Cliente("031.229.220.10", "ana");
                ContaCorrente conta1 = new ContaCorrente(12, 12, cliente1);
                ContaCorrente conta2 = new ContaCorrente(12, 12, cliente2);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);

                Console.ReadLine();
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine($"Não é possível divisão por zero {erro.Message}");
                //Console.WriteLine(erro.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.ValorSaque);
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("mensagem da innerException.");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (ArgumentException erro)
            {
                if (erro.ParamName == "numero")
                {
                    Console.WriteLine("erro de numero.");
                }
                Console.WriteLine(erro.Message);
                //Console.WriteLine($"{erro.ParamName}");
                //Console.WriteLine(erro.StackTrace);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Informação de inner exception");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        public static void Metodo()
        {
            TestaDivisao(10);
            TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {   
            int resultado = Dividir(10, divisor);
            Console.WriteLine($"consegui dividir o resultado é {resultado}");
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Exceção com numero= {numero} e divisor {divisor}");
                throw;
            }
        }
    }
}
