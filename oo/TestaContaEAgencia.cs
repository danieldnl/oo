using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    class TestaContaEAgencia
    {
        void Main()
        {
            Agencia a = new Agencia();
            Conta c = new Conta();

            a.numero = 2161;
            c.saldo = 1000.0;
            c.agencia = a;

            Console.WriteLine(c.agencia.numero);
            Console.WriteLine(c.saldo);
        }
    }
}
