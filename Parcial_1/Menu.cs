using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    static class Menu
    {
        
        static Menu() { }
        public static void MenuPrincipal()
        {
            Vehiculos c = new Vehiculos();
            Vendedores v = new Vendedores();
            Tipo t = new Tipo();
            byte opcion = 1;
            do
            {
                Console.WriteLine("-------------Menu Principal-------------");
                Console.WriteLine("1) Vehículos\n2) Ventas\n3) Reportes\n4) Salir");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: SubMenuVehiculos(); break;
                    case 2: c.Ventas(); break;
                    case 3: Console.WriteLine("Vehículos: ");
                        c.ImprimirTodo();
                        Console.WriteLine("Tipos dsiponibles: ");
                        t.ImprimirVehiculos();
                        Console.WriteLine("Vendedores: ");
                        v.ListadoVendedores();
                        break;
                    case 4: opcion = 4;break;
                    default:
                        break;

                }
            } while (opcion != 4);

        }
        public static void SubMenuVehiculos()
        {
            Vehiculos c = new Vehiculos();
            byte opcion = 1;
            do
            {
                Console.WriteLine("-------------Menu Vehículos-------------");
                Console.WriteLine("1) Agregar\n2) Consultar\n3) Modificar\n4) Volver a menú principal");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        c.AgregarVehiculo();
                        break;
                    case 2: 
                        c.ConsultarVehiculo(); break;
                    case 3: 
                        c.ModificarVehiculo(); break;
                    case 4:
                         break;
                    default:
                        break;
                }
            } while (opcion != 4);

        }
        
    }
}
