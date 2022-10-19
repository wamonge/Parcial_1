using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Vendedor2 : Vendedores, Ivendedor2 //Si no le hacía la herencia entonces no me permitía darle la interface, me daba error
    {
        public string nombreVendedor { get; set; }

        public Vendedor2(string nom) {
            nom = "Patricio";
        }
        public String VentasCredito() {
            string x = "x";
            //Si no le daba alguna variable de tipo string con un return me daba un error
            return x; }
}
}
