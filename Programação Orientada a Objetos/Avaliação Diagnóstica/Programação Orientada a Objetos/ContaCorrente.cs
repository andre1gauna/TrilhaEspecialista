using System;

public class ContaCorrente
{
    protected double saldo { get; set; }
    public string CPF { get; set; }
    public string nomeCliente { get; set; }

    public ContaCorrente(double saldo, string CPF, string nomeCliente)
    {
        this.saldo = saldo;
        this.CPF = CPF;
        this.nomeCliente = nomeCliente;
    }

    public void Sacar(double valorASacar)
    {
        if (saldo > valorASacar)
        {
            saldo -= valorASacar;
            Console.WriteLine("Saque efetuado com sucesso!");
        }
        else
            Console.WriteLine("Saldo insuficiente para saque");
    }

    public void Depositar(double valorADepositar)
    {
        saldo += valorADepositar;
        Console.WriteLine("Depósito efetuado!");
    }

    public void mostrarSaldo()
    {
        Console.WriteLine("O saldo é de: R$" + saldo); 
    }
}
