using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _06_ByteBank.Assets
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get;}

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo Arquivo:" + arquivo);
        }

        public string LerProximaLinha()
        {
            try
            {
                Console.WriteLine("Lendo linha...");
                throw new FileNotFoundException();

                return "Linha do Arquivo";
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando o Arquivo");
        }
    }
}
