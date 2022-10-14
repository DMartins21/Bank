using System.Globalization;
using Proje1.Entities;
using Proje1.Services;

try
{
    ContaCorrente cc = new(0.0,20.00);
    cc.Depositar(250.00);
    Console.WriteLine(cc.GetSaldo().ToString("F2", CultureInfo.InvariantCulture));
    
    cc.Sacar(200.00);
    Console.WriteLine(cc.GetSaldo().ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine();

    ContaPoupança cp = new(200.00);
    cp.Sacar(150.00);
    Console.WriteLine(cp.GetSaldo());

    cp.Depositar(40.00);
    Console.WriteLine(cp.GetSaldo());

    Console.WriteLine();
    GeradordeExtratos ge = new();
    Console.WriteLine(ge.GerarExtrato(cc));
    
}catch(Exception e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}