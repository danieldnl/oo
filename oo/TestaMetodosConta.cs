using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    class TestaMetodosConta
    {
        static void Main()
        {
            Conta c = new Conta();
            c.Deposita(1000);
            c.ImprimeExtrato();

            c.Saca(100);
            c.ImprimeExtrato();
        }
    }
}
