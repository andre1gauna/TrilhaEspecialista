using System;

public class ContaPoupança : ContaCorrente

{
	public double rendimento { get; set; }

	public ContaPoupança(double saldo, string CPF, string nomeCliente, double rendimento)
		: base(saldo, CPF, nomeCliente)
	{
		this.rendimento = rendimento;
	}

	public void alterarRendimento(double novoRendimento)
    {
		rendimento = novoRendimento;
		Console.WriteLine("Percentual de rendimento alterado");

	}
	public void AplicaRendimento()
	{
		saldo += saldo * rendimento;
		Console.WriteLine("Rendimento aplicado!");
	}
}
