using Proje1.Services;

namespace Proje1.Entities
{
    internal class ContaCorrente:IConta
    {
        public double Saldo { get; set; }
        public double Tarifa { get; set; }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        public ContaCorrente(double saldo, double tarifa)
        {
            Saldo = saldo;
            Tarifa = tarifa;
        }
                
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            Saldo -= Tarifa + valor;
            if(Saldo < 0)
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
