using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Servicio : lServiceInterface
    {
        public bool Operation(string cllave)
        {
            bool lResultado = false;
            if (cllave != "")
            {
                Console.WriteLine("El coche ha arrancado");
                lResultado = true;
            }

            return lResultado;
        }
    }
}
