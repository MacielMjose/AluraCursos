using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string Cpf 
        {
            get
            {
                return _cpf;
            }
            set
            {
                if(value.Length >= 11)
                {
                  _cpf = value;
                }

                return;
            }
        }
        public string Profissao { get; set; }

        public Cliente(string cpf, string nome)
        {
            _cpf = cpf;
            Nome = nome;
        }
    }
}
