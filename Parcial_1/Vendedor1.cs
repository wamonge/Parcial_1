using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    internal class Vendedor1 : Vendedores, Ivendedor1 //Si no le hacía la herencia entonces no me permitía darle la interface, me daba error
    {
        public string nombreVendedor { get; set; }

        public Vendedor1(string nom)
        {
            nom = "Paco";
        }
        public void VentasContado() { }

}
}
