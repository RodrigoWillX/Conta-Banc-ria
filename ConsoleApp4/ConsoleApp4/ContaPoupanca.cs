using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ContaPoupanca : Conta
    {
        private float rendimento;

        public ContaPoupanca(string nomeCliente, string agencia, string numeroConta,
float saldo, float rendimento) : base(nomeCliente, agencia,
numeroConta, saldo)
        {
            this.nomeCliente = nomeCliente;
            this.agencia = agencia;
            this.numeroConta = numeroConta;
            this.saldo = saldo;
            this.rendimento = rendimento;
        }


        public void AplicarRendimento()
        {
            saldo += rendimento;
            Console.WriteLine("Rendimento aplicado no valor de " + rendimento);
        }
    }
}
