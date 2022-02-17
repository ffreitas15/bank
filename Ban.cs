using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Principal
{
    class Ban
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
            Saldo = 0;
        }

        public Banco(int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }


        public void depósitoEmConta(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void SaqueEmConta(double quantia)
        {
            Saldo = Saldo - quantia + 5;
        }
        public override string ToString()
        {
            return "Dados da conta : " +
            "Conta : " + Conta +
           "Titular :" + Titular +
            "Saldo : " + Saldo;
        }
    }
}
