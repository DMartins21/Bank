using Proje1.Services;

namespace Proje1.Entities
{
    internal class ContaPoupança : ContaCorrente, IConta
    {
        public ContaPoupança(double saldo) : base(saldo) { }

        public override void Depositar(double valor) 
        {
            base.Depositar(valor);
        }
        public override void Sacar(double valor)
        {
            Saldo -= valor;
            if(Saldo < 0)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }
        }
        public override double GetSaldo() 
        {
            return Saldo;
        }
    }
}
