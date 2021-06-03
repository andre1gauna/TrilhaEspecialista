using System;

namespace Orientação_a_objetos___Avaliação_Diagnóstica
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente CC = new ContaCorrente(2500, "39428393823", " João Paulo da Cunha");
            ContaPoupança CP = new ContaPoupança(3893, "29318037713", "Maria Fonseca Conceição", 0.3);

            CC.Depositar(1300);
            CC.mostrarSaldo();
            CC.Sacar(6400);
            CC.Sacar(300.32);
            CC.mostrarSaldo();

            CP.AplicaRendimento();
            CP.mostrarSaldo();
            CP.alterarRendimento(0.45);
            CP.AplicaRendimento();
            CP.mostrarSaldo();


        }
    }
}
