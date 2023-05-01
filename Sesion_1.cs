using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImpresionNombre();
            ImpresioHora();

            Console.Read();
        }

        public static void ImpresionNombre()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}!");
        }
        public static void ImpresioHora()
        {
            DateTime ahora = DateTime.Now;
            string hora = ahora.ToString("hh:mm tt");
            Console.WriteLine($"La hora es {hora}!");
        }
    }
}
