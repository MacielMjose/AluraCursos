using _05_ByteBank;

namespace _02_ByteBank
{
    class ContaCorrente
    {
        public ContaCorrente(Cliente cliente) 
        {
            this.saldo = 100;
            this.titular = cliente;
            this.isActive = true;
        }
        
        public Cliente titular;
        public int numero { get; set; }
        public int agencia { get; set; }
        public double saldo { get; set; }
        public  bool isActive{ get; set; }


        public bool Sacar(double valorSaque)
        {
            if(this.saldo < valorSaque)
            {
                return false;
            }
            else
            {
                this.saldo -= valorSaque;

                return true;
            }
        }

        public void Depositar(double valorDeposito) => this.saldo += valorDeposito;

        public bool Transferir(double valor,ContaCorrente destino)
        {
            if(this.saldo >= valor)
            {
                this.Sacar(valor);
                destino.Depositar(valor);

                return true;
            }
            
            return false;
            
        }
    }
}
