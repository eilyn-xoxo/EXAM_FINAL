using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProy
{
    
class Conductor
        {
            public string NombreCompleto { get; set; }
            public string Cedula { get; set; }
            public string Direccion { get; set; }
            public string TipoLicencia { get; set; }
            public DateTime FechaNacimiento { get; set; }
        }

        class Vehiculo
        {
            public string Placa { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Color { get; set; }
            public int year { get; set; }
            public string NumeroChasis { get; set; }
        }

        class AgenteTransito
        {
            public string CodigoEmpleado { get; set; }
            public string NombreCompleto { get; set; }
            public string Direccion { get; set; }
            public DateTime FechaIngreso { get; set; }
        }

        class Infraccion
        {
            public string Tipo { get; set; }
            public decimal Penalidad { get; set; }
            public DateTime Fecha { get; set; }
            public DateTime now = DateTime.Now;

        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ingrese los datos del conductor:");
                Conductor conductor = new Conductor();
                Console.Write("Nombre completo: ");
                conductor.NombreCompleto = Console.ReadLine();
                Console.Write("Cedula: ");
                conductor.Cedula = Console.ReadLine();
                Console.Write("Direccion: ");
                conductor.Direccion = Console.ReadLine();
                Console.WriteLine("Indique su tipo de licencia - A, B o C: ");
                conductor.TipoLicencia = Console.ReadLine();
                Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
                conductor.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n------------------------------------------------------------------------------");


                Console.WriteLine("Ingrese los datos del vehículo:");
                Vehiculo vehiculo = new Vehiculo();
                Console.WriteLine("Placa: ");
                vehiculo.Placa = Console.ReadLine();
                Console.WriteLine("Marca: ");
                vehiculo.Marca = Console.ReadLine();
                Console.WriteLine("Modelo: ");
                vehiculo.Modelo = Console.ReadLine();
                Console.WriteLine("Color: ");
                vehiculo.Color = Console.ReadLine();
                Console.WriteLine("Año: ");
                vehiculo.year = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero de Chasis: ");
                vehiculo.NumeroChasis = Console.ReadLine();
            Console.WriteLine("\n------------------------------------------------------------------------------");

 
                Console.WriteLine("Ingrese los datos del agente de tránsito:");
                AgenteTransito agenteTransito = new AgenteTransito();
                Console.WriteLine("Codigo del empleado: ");
                agenteTransito.CodigoEmpleado = Console.ReadLine();
                Console.WriteLine("Nombre: ");
                agenteTransito.NombreCompleto = Console.ReadLine();
                Console.WriteLine("Dirección: ");
                agenteTransito.Direccion = Console.ReadLine();
                Console.WriteLine("Fecha de ingreso: ");
                agenteTransito.FechaIngreso = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n------------------------------------------------------------------------------");


                Console.WriteLine("Ingrese el tipo de infracción cometida:");
                Console.WriteLine("1. Obstrucción de tránsito");
                Console.WriteLine("2. Pase de semáforo en rojo ");
                Console.WriteLine("3. Hablar por el celular ");
                Console.WriteLine("4. Conducir sin el cinturón ");
                Console.WriteLine("5. Licencia vencida ");
                Console.Write("Seleccione el tipo de infracción : ");
            string tipoInfraccion = Console.ReadLine();

                Infraccion infraccion = new Infraccion();
            switch (tipoInfraccion.ToLower())
            {
                case "1":
                    infraccion.Tipo = "Obstrucción de tránsito";
                    infraccion.Penalidad = 1800.00m;
                    break;
                case "2":
                    infraccion.Tipo = "Pase de semáforo en rojo";
                    infraccion.Penalidad = 5950.00m;
                    break;
                case "3":
                    infraccion.Tipo = "Hablar por el celular";
                    infraccion.Penalidad = 3750.00m;
                    break;
                case "4":
                    infraccion.Tipo = "Conducir sin cinturón";
                    infraccion.Penalidad = 2560.00m;
                    break;
                case "5":
                    infraccion.Tipo = "Licencia vencida";
                    infraccion.Penalidad = 3890.00m;
                    break;
                default:
                    Console.WriteLine("Tipo de infracción no válido.");
                    return;
            }
            Console.WriteLine("\nDATOS DEL CONDUCTOR:");
            Console.WriteLine("Nombre completo: " + conductor.NombreCompleto);
            Console.WriteLine("Cedula: " + conductor.Cedula);
            Console.WriteLine("Direccion: " + conductor.Direccion);
            Console.WriteLine("Tipo de licencia: " + conductor.TipoLicencia);
            Console.WriteLine("Fecha de nacimiento: " + conductor.FechaNacimiento.ToShortDateString());

            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nDATOS DEL VEHICULO");
            Console.WriteLine("Placa: " + vehiculo.Placa);
            Console.WriteLine("Marca: " + vehiculo.Marca);
            Console.WriteLine("Modelo: " + vehiculo.Modelo);
            Console.WriteLine("Color: " + vehiculo.Color);
            Console.WriteLine("Año: " + vehiculo.year);
            Console.WriteLine("Numero de chasis: " + vehiculo.NumeroChasis);

            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nDATOS DEL AGENTE DE TRANSITO:");
            Console.WriteLine("Codigo de empleado: " + agenteTransito.CodigoEmpleado);
            Console.WriteLine("Nombre completo: " + agenteTransito.NombreCompleto);
            Console.WriteLine("Direccion: " + agenteTransito.Direccion);
            Console.WriteLine("Fecha de ingreso: " + agenteTransito.FechaIngreso.ToShortDateString());

            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nDATOS DE LA INFRACCION:");
            Console.WriteLine("Tipo: " + infraccion.Tipo);
            Console.WriteLine("Penalidad: " + infraccion.Penalidad.ToString("C2"));
            Console.WriteLine("Fecha: " + DateTime.Now);



            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

           
        }
    }



}