using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ClasseCorrente : Conta
    {
        private float taxa;

        public ClasseCorrente(string nomeCliente, string agencia, string numeroConta, 
        float saldo, float taxa) : base(nomeCliente, agencia, 
        numeroConta, saldo)
        {
            this.nomeCliente = nomeCliente;
            this.agencia = agencia;
            this.numeroConta = numeroConta;
            this.saldo = saldo;
            this.taxa = taxa;

        }

        public void AplicarTaxa()
        {
            saldo -= taxa;
            Console.WriteLine("Taxa aplicada no valor de: " + taxa);
        }
    }
}
