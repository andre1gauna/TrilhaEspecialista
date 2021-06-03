using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliação_Final
{
    public class Funcionario
    {
        public string nome { get; set; }
        public int cargaHoraria { get; set; }
        public double valorHora { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valorHora = valorHora;
        }

        public virtual double calcularSalario()
        {
            return cargaHoraria * valorHora;
        }
    }
}
