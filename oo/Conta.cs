using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    class Conta
    {
        public double saldo = 100.0;
        public Agencia agencia; // Agregação

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine("SALDO: " + this.saldo);
        }
    }
}
