using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Conta
    {
        protected string nomeCliente, agencia, numeroConta;
        protected float saldo;

        public Conta(string nomeCliente, string agencia, string numeroConta, float saldo)
        {
            this.nomeCliente = nomeCliente;
            this.agencia = agencia;
            this.numeroConta = numeroConta;
            this.saldo = saldo;

        }
        public void Sacar(float valorSaque)
        {
            Console.WriteLine(nomeCliente + " sacou " + valorSaque);
            saldo -= valorSaque;
            Console.WriteLine("Saldo atual: " + saldo);
        }

        public void Depositar(float valorDeposito)
        {
            Console.WriteLine(nomeCliente + " depositou " + valorDeposito);
            saldo += valorDeposito;
            Console.WriteLine("saldo atual: " + saldo);
        }
    }
}
