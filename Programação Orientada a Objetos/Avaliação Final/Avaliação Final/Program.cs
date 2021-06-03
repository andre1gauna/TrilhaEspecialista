using System;
using System.Collections.Generic;

namespace Avaliação_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> Funcionarios = new List<Funcionario>();
            Console.Write("Quantos funcionarios serão cadastrados? ");
            int numFuncionarios = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = numFuncionarios; i != 0; i--)
            {

                Console.Write("Insira o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Insira a carga horária: ");
                int ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Insira o valor por hora de salário: ");
                double pagamentoHora = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("É funcionário terceirizado? S ou N: ");
                string terceirizado = Console.ReadLine();

                if (terceirizado.ToLower() == "s")
                {
                    Console.Write("Insira o nome da empresa: ");
                    string empresa = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Insira a taxa de servico: ");
                    double taxa = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Funcionario FuncionarioTerceirizado = new FuncionarioTerceirizado(nome, ch, pagamentoHora, empresa, taxa);
                    Funcionarios.Add(FuncionarioTerceirizado);
                    Console.WriteLine("Nome: " + FuncionarioTerceirizado.nome);
                    Console.WriteLine("salario: " + FuncionarioTerceirizado.calcularSalario());
                    Console.WriteLine("Empresa: " + empresa);
                }
                else
                {
                    Funcionario Funcionario = new Funcionario(nome, ch, pagamentoHora);
                    Funcionarios.Add(Funcionario);
                    Console.WriteLine("Nome: " + Funcionario.nome);
                    Console.WriteLine("salario: " + Funcionario.calcularSalario());
                }
            }


        }
    }
}
