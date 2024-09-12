using System;
namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial contaEspecial = new ContaEspecial();  
            contaEspecial.NumeroDaConta = 1234;
            contaEspecial.Titular = "Lindomar";
            contaEspecial.Depositar(1000);
            contaEspecial.Sacar(500);
            contaEspecial.VerSaldo();  
        }
    }
}