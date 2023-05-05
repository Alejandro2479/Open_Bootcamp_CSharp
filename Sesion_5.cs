using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sesion_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If
            string nombre, email, tieneCupon;
            bool cupon;
            int precio = 100;
            double descuento = 0.25;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su email: ");
            email = Console.ReadLine();
            Console.Write("Tiene cupon? (Si o No): ");
            tieneCupon = Console.ReadLine().ToUpper();

            if (tieneCupon == "SI")
            {
                cupon = true;
            }
            else
            {
                cupon = false;
            }

            Console.WriteLine();

            if (cupon == true)
            {
                Console.WriteLine("Tiene un descuento!");
                Console.WriteLine($"El precio es {(precio) - (precio * descuento)}");
            }
            else
            {
                Console.WriteLine($"El precio es {precio}");
            }

            Console.WriteLine();

            // Switch
            List<string> lenguajes = new List<string> {"Python", "Java", "C#",};
            int seleccion = 0;

            if (seleccion == 0)
            {
                Console.WriteLine(@"Seleccione un lenguaje de la lista:
1. Python
2. Java
3. C#");
                seleccion = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            switch (seleccion)
            {
                case (1):
                    Console.WriteLine($"El lenguaje seleccionado es: {lenguajes[seleccion - 1]}");
                    break;
                case (2):
                    Console.WriteLine($"El lenguaje seleccionado es: {lenguajes[seleccion - 1]}");
                    break;
                case (3):
                    Console.WriteLine($"El lenguaje seleccionado es: {lenguajes[seleccion - 1]}");
                    break;
                default: 
                    Console.WriteLine("Seleccion incorrecta");
                    break;
            }

            Console.Read();
        }
    }
}
