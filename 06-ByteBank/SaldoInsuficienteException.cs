using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get;}
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this("tentativa de saque no valor " + valorSaque + " saldo da conta é " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string message) : base(message)
        {

        }
        
        public SaldoInsuficienteException(string message, Exception innerException)
            :base(message,innerException)
        {

        }
    }
}
