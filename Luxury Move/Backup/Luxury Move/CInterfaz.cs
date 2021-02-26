using System;
namespace Luxury_Move
{
    public class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static string darOpcion()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*   Sistema de Gestión de Vehículos de Lujo   *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n[E] Establecer seguro de garantía.");
            Console.WriteLine("\n[A] Agregar un vehículo.");
            Console.WriteLine("\n[P] Presupuestar un vehículo.");
            Console.WriteLine("\n[R] Remover un vehículo.");
            Console.WriteLine("\n[S] Salir de la aplicación.");
            Console.WriteLine("\n**********************************************");
            return CInterfaz.pedirDato("opción elegida");
        }
        public static string pedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
            //.Trim() Remueve espacios en blanco previos y posteriores.

        }
        public static void mostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

