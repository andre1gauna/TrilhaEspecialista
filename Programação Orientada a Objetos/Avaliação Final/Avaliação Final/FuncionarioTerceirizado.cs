using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliação_Final
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public string empresaOrigem { get; set; }
        public double taxaServico { get; set; }

        public FuncionarioTerceirizado()
        {

        }
   
        public FuncionarioTerceirizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico)
            :base (nome, cargaHoraria, valorHora)
        {
            this.empresaOrigem = empresaOrigem;
            this.taxaServico = taxaServico;
        }

        public override double calcularSalario()
        {
            double total = base.calcularSalario() * (1 + taxaServico);
            return total;
        }

        public void alterarEmpresaOrigem(string empresaOrigem)
        {
            this.empresaOrigem = empresaOrigem;
        }

        public void alterartaxaServico(double taxaServico)
        {
            this.taxaServico = taxaServico;
        }
    }
}
