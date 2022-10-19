using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    internal class Mat
    {
        static float total = 0;
        static float cantidad;

        public void CalculoTotal(float costo) {
            cantidad = cantidad + 1;
            total = total + costo;
            Console.WriteLine("La cantidad de vehículos es de {0} y el total a cancelar es de {1}",cantidad, total);
        }
    }
}
