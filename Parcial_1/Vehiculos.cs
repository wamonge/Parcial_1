using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Vehiculos
    {
       
        string codigo { get; set; }
        string marca { get; set; }
        float costo { get; set; }
        string modelo { get; set; }

        static string[] codigos = new string[5] { "x", "x", "x", "x", "x" };
        static string[] marcas = new string[5] { "x", "x", "x", "x", "x" };
        static float[] costos = new float[5] { 0, 0, 0, 0, 0 };
        static string[] modelos = new string[5] { "x", "x", "x", "x", "x" };

        public Vehiculos()
        {
        }
        public Vehiculos(string cod, string marc, float costo, string mod)
        {
            string codigo = cod;
            string marco = marc;
            float cos = costo;
            string modelo = mod;
        }

        public void AgregarVehiculo()
        {
            int x = 0;
            for (int i = 0; i < 5; i++)
            {
                if ("x" != codigos[i])
                {
                    x = x + 1;
                }
            }
            if (x >= 5)
            {
                Console.WriteLine("No se pueden agregar más vehículos");
            }
            if (x < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if ("x" == codigos[i] && "x" == marcas[i] && 0 == costos[i] && "x" == modelos[i])
                    {
                        Console.WriteLine("Introduzca el código del vehículo");
                        codigos[i] = Console.ReadLine();
                        Console.WriteLine("Introduzca la marca del vehículo");
                        marcas[i] = Console.ReadLine();
                        Console.WriteLine("Introduzca el costo del vehículo");
                        costos[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el modelo del vehículo");
                        modelos[i] = Console.ReadLine();
                        Console.WriteLine("El código del vehículo es {0}, la marca es {1}, el costo es de {2} y su modelo es {3}",
                        codigos[i], marcas[i], costos[i], modelos[i]);
                        i = 6;
                    }
                }
            }
        }
        public void ModificarVehiculo()
        {
            string buscar = "";
            int x = 0;
            Console.WriteLine("Introduzca el código del vehículo que desea modificar");
            buscar = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (buscar == codigos[i])
                {
                    Console.WriteLine("Introduzca el nuevo código del vehículo");
                    codigos[i] = Console.ReadLine();
                    Console.WriteLine("Introduzca la nueva marca del vehículo");
                    marcas[i] = Console.ReadLine();
                    Console.WriteLine("Introduzca el nuevo costo del vehículo");
                    costos[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el nuevo modelo del vehículo");
                    modelos[i] = Console.ReadLine();
                    i = 4;

                }
                if (buscar != codigos[i])
                {
                    x = x + 1;
                }


            }
            if (x >= 5)
            {
                Console.WriteLine("No se encuentra el vehículo con código {0}", buscar);
            }

        }
        public void ConsultarVehiculo()
        {
            string buscar = "";
            int x = 0;
            Console.Write("Introduzca el código del vehículo que desea buscar: ");
            buscar = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                
                if (buscar == codigos[i])
                {
                    Console.WriteLine("El código del vehículo es {0}, la marca es {1}, el costo es de {2} y su modelo es {3}",
                        codigos[i], marcas[i], costos[i], modelos[i]);
                    i = 4;
                }
                if (buscar != codigos[i])
                {
                    x = x + 1;
                }

            }
            if (x >= 5)
            {
                Console.WriteLine("No se encuentra el vehículo con código {0}", buscar);
            }

        }
        public void Ventas()
        {
            string buscar = "";
            float cost = 0;
            int x = 0;
            Console.Write("Introduzca el código del vehículo: ");
            buscar = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                
                if (buscar == codigos[i])
                {
                    Console.WriteLine("El código del vehículo es {0}, la marca es {1} y el costo es de {2}",
                        codigos[i], marcas[i], costos[i]);
                    cost = costos[i];


                }
                if (buscar != codigos[i])
                {
                    x = x + 1;
                }

            }
            if (x >= 5)
            {
                Console.WriteLine("No se encuentra el vehículo con código {0}, por lo que no se realizó la compra", buscar);
            }
            else
            {
                Tipo t = new Tipo();
                t.Listado_Vehiculos();
                if (t.control1 == true)
                {
                    Vendedores v = new Vendedores();
                    Console.WriteLine("Digite el código del vendedor que desea buscar");
                    string value = Console.ReadLine();
                    v.MostrarVendedor(value);
                    if (v.control2==true)
                    {
                        Mat m = new Mat();
                        m.CalculoTotal(cost);
                    }
                    else
                    {
                        Console.WriteLine("No se realizó la compra ya que el vendedor no existe");
                    }

                }
                else
                {
                    Console.WriteLine("No se realizó la compra ya que el tipo de vehículo no existe");
                }
                
            }



        }
        public void ImprimirTodo()
        {
            for (int i = 0; i < 4; i++)
            {
                if ("x" == codigos[i])
                {

                }
                else
                {
                    Console.WriteLine("Código: {0}; Marca: {1}; Costo: {2}; Modelo: {3}",
                    codigos[i], marcas[i], costos[i], modelos[i]);
                }
                
            }


        }
    }
}
