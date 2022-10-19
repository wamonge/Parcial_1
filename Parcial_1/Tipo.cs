using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Tipo
    {
        public Boolean control1 = false;
        List<string> VehiculosExistentes = new List<string>() {"Motocicleta", "Automóvil", "Dron"};
        //Motocicleta, Automóvil, Dron
        public void Tipo_Vehiculo() {
            Console.WriteLine("Existen diferentes tipos de vehículo");
        }
        public void Listado_Vehiculos() {
            Boolean existe = false;
            string buscar = "";
            Console.WriteLine("Digite el tipo de vehículo que desea buscar");
            buscar = Console.ReadLine();
            foreach (string x in this.VehiculosExistentes)
            {
                if (buscar == x)
                {
                    existe = true;
                    control1 = true;
                    if (x == "Motocicleta")
                    {
                        Motocicleta m = new Motocicleta();
                        m.Tipo_Vehiculo();
                    }
                    if (x == "Automóvil")
                    {
                        Automovil m = new Automovil();
                        m.Tipo_Vehiculo();
                    }
                    if (x == "Dron")
                    {
                        Dron m = new Dron();
                        m.Tipo_Vehiculo();
                    }
                }
            }
            if (existe == false)
            {
                Console.WriteLine("El tipo de vehículo no existe.");
            }
        }
        public void ImprimirVehiculos() {
            foreach (string vehi in VehiculosExistentes)
            {
                Console.WriteLine(vehi);
            }
        }

    }
}
