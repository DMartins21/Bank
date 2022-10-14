namespace Proje1.Services
{
    internal class GeradordeExtratos : IConta
    {
        public void Depositar(double valor)
        {}

        public double GerarExtrato(IConta c)
        {
            return c.GetSaldo();
        }

        public double GetSaldo()
        {
            return 0;
        }

        public void Sacar(double valor)
        {}
    }
}