using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string llave = "";
            Proxy proxy = new Proxy();
            Console.WriteLine("Introdusca su llave");
            llave = Console.ReadLine();

            if (llave != "") {
                Console.WriteLine("Se ha introducido la llave");
            }

            if (proxy.Operation(llave))
            {
                Console.WriteLine("Se prendio el motor");
            }
            Console.ReadLine();
        }
    }
}
