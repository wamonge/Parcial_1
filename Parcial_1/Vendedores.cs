using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Vendedores
    {
        public Boolean control2 = false;
        public Dictionary<string, string> vendedores = new Dictionary<string, string>()
        {
           {"1", "Paco"},
           {"2", "Patricio"}
        };

        public Vendedores() 
        { 
        }

        public void ListadoVendedores() {
            foreach (var x in vendedores)
            {
                Console.WriteLine($"Codigo:{x.Key} Nombre del vendedor: {x.Value}");
            }
        }
        public String MostrarVendedor(string value)
        {
            string result;
            if (vendedores.TryGetValue(value, out result))
            {
                control2 = true;
                Console.WriteLine("El nombre del vendedor con código {0}, es: {1}",value, result);
            }
            else
            {
                Console.WriteLine("No se encontró el vendedor con código " + value);
            }
            return value;
        }
    }
}
