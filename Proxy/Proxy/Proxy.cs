using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy : lServiceInterface
    {
        public Servicio realService { get; set; }

        public void Proxyd(Servicio s) {
            realService = s;
        }
        public bool checkAccess(string cllave) {
            bool lResultado = false;
            if (cllave != "")
            {
                lResultado = true;
            }
            else {
                Console.WriteLine("No tiene permisos para prender el motor");
            }
            return lResultado;
        }
        public bool Operation(string cllave)
        {
            bool lResultado = false;
            if(checkAccess(cllave)){
                Servicio s = new Servicio();
                lResultado = s.Operation(cllave);
            }
            return lResultado;
        }
    }
}
