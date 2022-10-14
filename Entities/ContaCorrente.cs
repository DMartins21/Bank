using Proje1.Services;

namespace Proje1.Entities
{
    internal class ContaCorrente:IConta
    {
        public double Saldo { get; set; }
        public double Tarifa { get; set; }

        public ContaCorrente(double saldo, double tarifa)
        {
            Saldo = saldo;
            Tarifa = tarifa;
        }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            Saldo = Saldo - valor - Tarifa;
            if(Saldo > valor)
            {
                throw new ArgumentException("Saldo Insuficiente.");
            }
        }

        public virtual double GetSaldo()
        {
            return Saldo;
        }
    }
}
