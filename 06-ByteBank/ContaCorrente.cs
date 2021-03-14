using System;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private const string ERRO_AGENCIA = "O Argumento agencia deve ser maior que zero.";
        private const string ERRO_NUMERO = "O Argumento numero deve ser maior que zero.";
        private const string VALOR_SAQUE = "Valor de saque invalido.";
        private const string VALOR_TRANSFEREINCIA = "Valor de transferencia inválido.";

        public int Numero { get; }
        public int Agencia { get; }
        public bool IsActive { get; set; }
        public Cliente Titular { get; set; }
        
        private double _saldo;
        private readonly int _numero;
        private readonly int _agencia;
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }


        public static int TotalContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        public ContaCorrente(int agencia, int numero, Cliente cliente)
        {
            _= agencia <= 0 ? throw new ArgumentException(ERRO_AGENCIA , nameof(agencia)) : _agencia = agencia;
            _= numero <= 0 ? throw new ArgumentException(ERRO_NUMERO, nameof(numero)) : _numero = numero;

            _agencia = agencia;
            _numero = numero;
            Titular = cliente;
            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;
        }

        public double Saldo
        {
            get {return _saldo; }
            set {
                    if (value < 0)
                    {
                        return;
                    }
                _saldo = value;
            }
        }

        public void Sacar(double valorSaque)
        {
            if(valorSaque < 0)
            {
                throw new ArgumentException(VALOR_SAQUE + nameof(valorSaque));
            }
            if (_saldo < valorSaque)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valorSaque);
            }
        
            _saldo -= valorSaque;
        }

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            else
            {
                _saldo = saldo;
            }
        }

        public void Depositar(double valorDeposito) => _saldo += valorDeposito;

        public void Transferir(double valor, ContaCorrente destino)
        {
            _ = valor <= 0 ? throw new ArgumentException(VALOR_TRANSFEREINCIA + nameof(valor)) : valor = valor;

            try
            {
                Sacar(valor);
                destino.Depositar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada",ex);
            }
        }
    }
}
