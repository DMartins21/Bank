using System.Globalization;
using Proje1.Entities;
using Proje1.Services;

try
{
    Console.Write("Saldo Inicial da Conta: ");
    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Digite o valor do deposito: ");
    double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Sera feito algum saque(s/n)? ");
    char s = char.Parse(Console.ReadLine());
    Console.Write("Digite o tipo de conta(Corrente ou Poupança(c/p)): ");
    char c = char.Parse(Console.ReadLine());
    if(c == 'c')
    {
        Console.Write("Qual o valor da tarifa por saque: ");
        double tarifa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ContaCorrente cc = new(saldo,tarifa);
        cc.Depositar(deposito);
        if (s == 's')
        {
            Console.Write("Qual o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc.Sacar(saque);
        }
        GeradordeExtratos ge = new();
        Console.WriteLine("Saldo: " + ge.GerarExtrato(cc));
    }
    else
    {
        ContaPoupança p = new(saldo);
        p.Depositar(deposito);
        if (s == 's')
        {
            Console.Write("Qual o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Sacar(saque);
        }
        GeradordeExtratos ge = new();
        Console.WriteLine("Saldo: " + ge.GerarExtrato(p));
    }
}
catch(Exception e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}