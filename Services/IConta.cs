namespace Proje1.Services
{
    internal interface IConta
    {
        public void Depositar(double valor);
        public void Sacar(double valor);
        public double GetSaldo();
    }
}
